
# Remove exist sdk from $RPMapping
$total = 0
$sdkFolder = Get-ChildItem $PSScriptRoot\..\..\sdk

$sdkFolder  | ForEach-Object {
    $curSdkFolder = @(Get-ChildItem $_) 
    foreach ($existSdk in $curSdkFolder) {
        if ($existSdk.Name -match "Microsoft") {
            Continue
        }
        if ($existSdk.Name -match "Azure.ResourceManager.") {
            $curSdk = Get-ChildItem $existSdk.FullName
            if ($curSdk.Length -le 3) {
                Remove-Item -Path $existSdk.FullName -Recurse
                Write-Host "["$existSdk.FullName"] has been deleted"
                $total++
            }
        }
    }
}
Write-Host "total: $total"