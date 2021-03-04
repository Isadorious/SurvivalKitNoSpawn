Param([string]$SolutionDir)
New-Item -ItemType Directory -Force -Path "$SolutionDir\TorchBinaries\Plugins\SurvivalKitNoSpawn"
copy-item -path "$SolutionDir\SurvivalKitSpawn\bin\x64\Debug\*" -Destination "$SolutionDir\TorchBinaries\Plugins\SurvivalKitSpawn" -Force