# Upgrade Options — eshop-microservices

Assessment: 2 SDK-style projects on .NET 8, one dependency tier, and 1 incompatible package for .NET 10.

## Strategy

### Upgrade Strategy
The small modern-.NET solution has only two projects, a shallow dependency graph, and no API incompatibilities.

| Value | Description |
|-------|-------------|
| **All-at-Once** (selected) | Upgrade both projects in one atomic pass and validate the complete solution afterward. |
| Top-Down | Upgrade the API first while temporarily multi-targeting shared libraries, then consolidate. |

## Compatibility

### Unsupported Packages
The assessment identified one incompatible package: Microsoft.VisualStudio.Azure.Containers.Tools.Targets 1.23.0.

| Value | Description |
|-------|-------------|
| **Resolve Inline** (selected) | Research and resolve the incompatible package within the project upgrade task. |
| Defer Resolution | Remove the package and use minimal stubs, then create a follow-up replacement task. |
| Compatibility Mode | Retain a legacy-compatible reference; this is intended only for suitable transitive or Windows-only dependencies. |
