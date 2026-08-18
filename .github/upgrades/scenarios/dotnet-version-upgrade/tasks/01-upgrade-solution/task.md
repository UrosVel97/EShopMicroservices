# 01-upgrade-solution: Upgrade all projects to .NET 10

Upgrade `BuildingBlocks.csproj` and `Catalog.API.csproj` together from `net8.0` to `net10.0`. Verify the .NET 10 SDK and repository SDK constraints, then resolve the assessment finding for `Microsoft.VisualStudio.Azure.Containers.Tools.Targets` inline while preserving the existing project reference and application behavior. Research should confirm whether a supported package version is available or whether the development-only package can safely be removed.

**Done when**: The .NET 10 SDK is available, both projects target `net10.0`, all direct packages restore without compatibility or vulnerability warnings, and the solution compiles with zero errors and zero warnings.
