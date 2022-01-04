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
            $rpNameMatchResult = $item -match "Azure\.Management\.[^\/]+"
            if ($rpNameMatchResult -ne $false) {
                $rpName = $matches[0].Replace("Management", "ResourceManager")
            }
            if (($outputFolder -ne '') -and ($rpName -ne '')) {
                return @{ $rpName = $outputFolder }
            }
        }
    }
    return $false
}

function Update-Branch([string]$CommitId, [string]$Path){
    $file = $path + "\src\autorest.md"
    $fileContent = Get-Content $file
    $store = @()
    foreach($item in $fileContent)
    {
        $store += $item.ToString().Replace("master",$CommitId)
    }
    $store | Out-File -FilePath $file
}

function Generate-Code($folder)
{
    & cd $folder
}

function Invoke-Block([scriptblock]$cmd) {
    $cmd | Out-String | Write-Verbose
    & $cmd

    # Need to check both of these cases for errors as they represent different items
    # - $?: did the powershell script block throw an error
    # - $lastexitcode: did a windows command executed by the script block end in error
    if ((-not $?) -or ($lastexitcode -ne 0)) {
        if ($error -ne $null)
        {
            Write-Warning $error[0]
        }
        throw "Command failed to execute: $cmd"
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
        $newGenerateSdk = 0
        $mocktestSucceedRp = 0
        $testBuildSucceedRp  = 0
        $srcBuildSucceedRp = 0
        $succeedTestcases = 0
        $totalTestcases = 0
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
            $csharpReadmePath = "../azure-rest-api-specs/specification/$($_.Name)/resource-manager/readme.csharp.md"
            $readmePath = "../azure-rest-api-specs/specification/$($_.Name)/resource-manager/readme.md"
            if (Test-Path $csharpReadmePath) {
                $result = Find-Mapping($readmePath )
                if ($result -ne $false) {
                    $RPMapping += $result
                }
            }
            elseif (Test-Path $readmePath) {
                $result = Find-Mapping($readmePath )
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
                $generateSdkName = $sdkName.ToString().Replace("Azure.ResourceManager.","")
                $generateSdkPath = $PSScriptRoot.ToString().Replace("eng\scripts","sdk\")+ $RPMapping[$sdkName] + "\Azure.Resourcemanager." + $generateSdkName
                Write-Host $generateSdkName
                Write-Host $generateSdkPath
                dotnet new azuremgmt -p $generateSdkName -o $generateSdkPath
                Update-Branch -CommitId $CommitId -Path $generateSdkPath
                $newGenerateSdk ++

                # Generete new template src code
                Invoke-Block {
                    & cd $generateSdkPath"\src"
                    & dotnet build /t:GenerateCode
                }
            }
        }
        Write-Host "end"
    }
    end {
        Write-Host "Mock Test Initialize Completed."
        Write-Host "New generated track2 RPs: $newGenerateSdk" 
        Write-Host "srcBuildSucceedRp: $srcBuildSucceedRp" 
        Write-Host "mocktestSucceedRp: $mocktestSucceedRp" 
        Write-Host "testBuildSucceedRp: $testBuildSucceedRp" 
        Write-Host "succeedTestcases: $succeedTestcases "
        Write-Host "totalTestcases: $totalTestcases "
    }
}

MockTestInit -SpecsRepoPath "D:\repo\azure-rest-api-specs" -CommitId "322d0edbc46e10b04a56f3279cecaa8fe4d3b69b"
