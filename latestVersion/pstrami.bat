@echo off
powershell.exe -NoProfile -ExecutionPolicy unrestricted -Command "& { import-module .\pstrami.psm1 ; Send-Package -server "%~1" -destinationDirectory "%~2" -cmd '%~3'; if ($lastexitcode -ne 0) {write-host "ERROR: $lastexitcode" -fore RED; exit $lastexitcode} }"