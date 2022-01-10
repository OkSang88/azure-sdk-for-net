function Find-Mapping([string]$path) {
    $fileContent = Get-Content $path
    $outputFolder = ''
    $rpName = ''
    foreach ($item in $fileContent) {
        if (($item -match '\$\(csharp-sdks-folder\)')) {
            $outputFolderMatchResult = $item -match "\/([^/]+)\/"
            if ($outputFolderMatchResult -ne $false) {
                $outputFolder = $matches[0].Replace("/", "")
            }

            #rpName has mutiple match rules
            $rpNameMatchResult = $item -match "Azure\.Management\.[^\/]+"
            if ($rpNameMatchResult -ne $false) {
                $rpName = $matches[0].Replace("Management", "ResourceManager")
                break
            }
            $rpNameMatchResult = $item -match "Microsoft\.Azure\.[^\/]+"
            if ($rpNameMatchResult -ne $false) {
                $rpName = $matches[0].Replace("Microsoft.Azure", "Azure.ResourceManager")
                break
            }
            $rpNameMatchResult = $item -match "management\/[^\/]+\/GeneratedProtocol"
            if ($rpNameMatchResult -ne $false) {
                $rpName = $matches[0].Replace("management/Microsoft.", "Azure.ResourceManager.").Replace("/GeneratedProtocol", "")
                break
            }
            $rpNameMatchResult = $item -match "\(csharp-profile\)\/[^\/]+\/Management"
            if ($rpNameMatchResult -ne $false) {
                $outputFolder = $matches[0].Replace("(csharp-profile)/", "").Replace("/Management", "").ToLower()
                $rpName = $matches[0].Replace("(csharp-profile)/", "Azure.ResourceManager.").Replace("/Management", "")
                break
            }
            if ($rpNameMatchResult -eq $false) {
                Write-Host $item
                break
            }
        }
    }
    if (($outputFolder -ne '') -and ($rpName -ne '')) {
        return @{ $rpName = $outputFolder }
    }
    return $false
}

function Update-Branch([string]$CommitId, [string]$Path) {
    $file = $path + "\src\autorest.md"
    $fileContent = Get-Content $file
    $store = @()
    foreach ($item in $fileContent) {
        $store += $item.ToString().Replace("master", $CommitId)
    }
    $store | Out-File -FilePath $file
}

function Generate-Code([string]$path) {
    #[scriptblock]$cmd
    & cd $path
    & dotnet build /t:GenerateCode
    # if ($?) {
    #     & dotnet build
    # }
    # if ($?) {
    #     $Script:srcBuildSuccessedRp++
    # }
}

function Generate-Mocktests([string]$path) {
    $count = $path.IndexOf("ResourceManager.")
    $RPName = $path.Substring($count, $path.Length - $count).Replace("ResourceManager.", "")
    $mocktestsFolder = $path + "/mocktests"
    $srcFolder = $path + "/src"
    $generatedFolder = $path + "/src/Generated"
    $md = $mocktestsFolder + "/autorest.tests.md"
    $csproj = ($mocktestsFolder + "/Azure.ResourceManager.Template.Tests.csproj").Replace("Template", $RPName)

    # Create [mocktests] folder
    if (!(Test-Path $md) -or !(Test-Path $csproj)) {
        # please check [azmocktests] template has been imported
        New-Item -Path $path -Name "mocktests" -ItemType "directory"
        & cd $mocktestsFolder
        & dotnet new azmocktests -n $RPName
    }

    # Check [Generated] folder is not empty
    $count = (Get-ChildItem $generatedFolder).Count
    # build [src], if it fail, donot generate this RP's mocktests
    if ($count -ne 0) {
        & cd $srcFolder
        & dotnet build
        if ($?) {
            $Script:srcBuildSuccessedRp += $RPName
        }
        else {
            $Script:srcBuildErrorRPs += $RPName
            return
        }
    }
    else {
        $Script:codegenErrorRPs += $RPName
        return
    }

    # Generate and Build [mocktests]
    if ((Test-Path $md) -and (Test-Path $csproj) -and ($count -ne 0)) {
        # please check luanch MockTest-Host. 
        # Ref: https://github.com/changlong-liu/azure-sdk-for-net/blob/20211222-doc-for-mock-test/doc/dev/Using-Mock-Test-Generation.md
        & autorest --use=D:\repo\autorest.csharp\artifacts\bin\AutoRest.CSharp\Debug\netcoreapp3.1 $md --testmodeler #--debug
        if ($?) {
            $Script:testGenerateSuccesseddRp += $RPName
            & cd $mocktestsFolder
            & dotnet build
            if ($?) {
                $Script:testBuildSuccessedRp += $RPName
            }
            else {
                $Script:mockBuildErrorRPs += $RPName
            }
        }
        else {
            $Script:mockGenerateErrorRPs += $RPName
        }
    }
}

function  MockTestInit {
    param(
        [Parameter()]
        [string] $SpecsRepoPath,
        [Parameter()]
        [string] $SpecsVersion,
        [Parameter()]
        [string] $CommitId
    )
    begin {
        Write-Host "Mock Test Initialize Start."
        # Define statistical variables
        # a) mocktest-succeed-rp/test-build-succeed-rp/src-build-succeed-rp
        # b) each RP: succeed-testcases/total-testcases
        # c) total: succeed-testcases/total-testcases
        $Error.Clear()
        $Script:allTrack2Sdk = 0
        $Script:newGenerateSdk = 0
        $Script:srcBuildSuccessedRp = @()
        $Script:testGenerateSuccesseddRp = @()
        $Script:testBuildSuccessedRp = @()

        $Script:succeedTestcases = 0
        $Script:totalTestcases = 0

        $Script:codegenErrorRPs = @()
        $Script:srcBuildErrorRPs = @()
        $Script:mockGenerateErrorRPs = @()
        $Script:mockBuildErrorRPs = @()
    }
    process {
        # Get Specs Repo
        if (Test-Path $SpecsRepoPath) {
            $folderNames = Get-ChildItem $SpecsRepoPath/specification
        }
        else {
            git clone https://github.com/Azure/azure-rest-api-specs.git C:\ProgramData
            $folderNames = Get-ChildItem C:\ProgramData\azure-rest-api-specs\specification
        }

        # Get RP Mapping
        Write-Output "Start RP mapping "
        $RPMapping = [ordered]@{ }
        $readmePath = ''
        $folderNames | ForEach-Object {
            $csharpReadmePath = "$($_.FullName)/resource-manager/readme.csharp.md"
            $readmePath = "$($_.FullName)/resource-manager/readme.md"
            if (Test-Path $csharpReadmePath) {
                $result = Find-Mapping($csharpReadmePath)
                if ($result -ne $false) {
                    $RPMapping += $result
                }
            }
            elseif (Test-Path $readmePath) {
                $result = Find-Mapping($readmePath)
                if ($result -ne $false) {
                    $RPMapping += $result
                }
            }
        }

        # Remove exist sdk from $RPMapping
        $sdkFolder = Get-ChildItem $PSScriptRoot\..\..\sdk
        $sdkExistFolder = @()
        $sdkFolder  | ForEach-Object {
            $sdkExistFolder += $_.Name
            $curSdkFolder = @(Get-ChildItem $_) 
            foreach ($existSdk in $curSdkFolder) {
                if ($RPMapping.Contains($existSdk.Name)) {
                    $RPMapping.Remove($existSdk.Name)
                }
            }
        }

        # Generate Sdk Track2 folder if it not exist
        foreach ($sdkName in $RPMapping.Keys) {
            if ($sdkExistFolder.Contains($RPMapping[$sdkName])) {
                $generateSdkName = $sdkName.ToString().Replace("Azure.ResourceManager.", "")
                $generateSdkPath = $PSScriptRoot.ToString().Replace("eng\scripts", "sdk\") + $RPMapping[$sdkName] + "\Azure.ResourceManager." + $generateSdkName
                Write-Host $generateSdkName
                Write-Host $generateSdkPath
                dotnet new azuremgmt -p $generateSdkName -o $generateSdkPath
                Update-Branch -CommitId $CommitId -Path $generateSdkPath
                $Script:newGenerateSdk ++

                # Generete new template src code
                Generate-Code -path $generateSdkPath"\src"
            }
        }

        # Build all RPs, if it build succeess, run MockTest script
        $sdkFolder = Get-ChildItem $PSScriptRoot\..\..\sdk
        $sdkExistFolder = @()
        $sdkFolder  | ForEach-Object {
            $curFolderPRs = Get-ChildItem($_)
            foreach ($item in $curFolderPRs) {
                if ($item.FullName.Contains("Azure.ResourceManager")) {
                    # Create mocktests folder if it not exist
                    $Script:allTrack2Sdk++
                    Generate-Mocktests($item.FullName)
                }
            }
        }
    }
    end {
        Write-Host "Mock Test Initialize Completed."
        Write-Host "Track2 SDK Total: $Script:allTrack2Sdk"
        Write-Host "New generated track2 RPs: $Script:newGenerateSdk" 
        Write-Host "srcBuildSuccessedRp: "$Script:srcBuildSuccessedRp.Count 
        Write-Host "testGenerateSuccesseddRp: "$Script:testGenerateSuccesseddRp.Count 
        Write-Host "testBuildSuccessedRp: "$Script:testBuildSuccessedRp.Count 
        Write-Host "[TODO]succeedTestcases: $Script:succeedTestcases "
        Write-Host "[TODO]totalTestcases: $Script:totalTestcases "
        Write-Host "Src generate error RPs: $Script:codegenErrorRPs"
        Write-Host "Src build error RPs: $Script:srcBuildErrorRPs"
        Write-Host "Mock test generate error RPs: $Script:mockGenerateErrorRPs"
        Write-Host "Mock test build error RPs: $Script:mockBuildErrorRPs"
    }
}

MockTestInit -SpecsRepoPath "D:\repo\azure-rest-api-specs" -CommitId "322d0edbc46e10b04a56f3279cecaa8fe4d3b69b"
