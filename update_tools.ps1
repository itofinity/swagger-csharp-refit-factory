Remove-Item "$PSScriptRoot\tools\*"


$start_time = Get-Date
Invoke-WebRequest -Uri "http://central.maven.org/maven2/io/swagger/swagger-codegen-cli/2.2.3/swagger-codegen-cli-2.2.3.jar" -OutFile "$PSScriptRoot\tools\swagger-codegen-cli-2.2.3.jar"
Write-Output "Time taken: $((Get-Date).Subtract($start_time).Seconds) second(s)"

$start_time = Get-Date
Start-Process -FilePath "$PSScriptRoot\swagger-csharp-refit\build.cmd" -WorkingDirectory "$PSScriptRoot\swagger-csharp-refit"
Copy-Item -Path "$PSScriptRoot\swagger-csharp-refit\target\*.jar" -Destination "$PSScriptRoot\tools"
Write-Output "Time taken: $((Get-Date).Subtract($start_time).Seconds) second(s)"

