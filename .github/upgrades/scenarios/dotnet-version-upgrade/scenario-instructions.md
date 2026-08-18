# .NET Version Upgrade

## Preferences
- **Flow Mode**: Automatic
- **Target Framework**: net10.0

## Source Control
- **Source Branch**: main
- **Working Branch**: upgrade-dotnet-10
- **Commit Strategy**: Single Commit at End
- **Branch Sync**: Auto (Merge)

## Upgrade Options
**Source**: .github/upgrades/scenarios/dotnet-version-upgrade/upgrade-options.md

### Strategy
- Upgrade Strategy: All-at-Once

### Compatibility
- Unsupported Packages: Resolve Inline (1 incompatible package)

## Key Decisions Log
- **2026-08-18**: Confirmed the All-at-Once strategy and inline resolution of the incompatible package for the .NET 10 upgrade.

## Strategy
**Selected**: All-at-Once
**Rationale**: The solution contains only two SDK-style .NET 8 projects, a shallow dependency graph, no incompatible APIs, and one package compatibility issue.

### Execution Constraints
- Update both projects in one atomic upgrade operation rather than dependency tiers.
- Resolve the incompatible package during the upgrade task before validation.
- Restore after all project and package changes are applied.
- Build the complete solution and fix all errors and warnings in a bounded pass.
- Run tests only after the atomic upgrade builds successfully.
