#Requires -Version 7.0

param(
    [string] $Filter
)

$ErrorActionPreference = 'Stop'
Set-StrictMode -Version 3.0
$root = (Resolve-Path "$PSScriptRoot/../..").Path.Replace('\', '/')
. "$root/eng/scripts/preview/CommandInvocation-Helpers.ps1"
Set-ConsoleEncoding
Write-Host "Filter: '$Filter'"
Push-Location $root
try {
    # check if shared code is up to date
    & "$root/eng/scripts/preview/Check-SharedCode.ps1"

    # build CADL Ranch Mock Api project
    Push-Location "$root/test/CadlRanchMockApis"
    try {
        Invoke-LoggedCommand "npm run build" -GroupOutput
    }
    finally {
        Pop-Location
    }

    # run E2E Test for TypeSpec emitter
    Write-Host "Generating test projects under "$Filter"..."
    & "$root/eng/Generate.ps1" -Filter "$Filter" -Reset
    Write-Host 'Code generation is completed.'

    Write-Host 'Checking for differences in generated code...'
    git -c core.safecrlf=false diff --ignore-space-at-eol --exit-code
    if ($LastExitCode -ne 0) {
        Write-Error 'Generated code is not up to date. Please run: eng/Generate.ps1'
        exit 1
    }
    Write-Host 'Done. No code generation differences detected.'
}
finally {
    Pop-Location
}
