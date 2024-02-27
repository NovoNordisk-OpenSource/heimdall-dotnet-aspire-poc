# heimdall-dotnet-aspire-poc
POC code for .NET Aspire

WIP = WORK IN PROGRESS

## Install .NET Aspire SDK components

1) Update workloads via DOTNET CLI: `dotnet workload update`
2) Install Aspire workload via DOTNET CLI: `dotnet workload install aspire`
3) Verify Aspire workload installed via DOTNET CLI: `dotnet workload list`

## Start processes

To bootstrap the required application processes run the following command: `dotnet run --project heimdall-templates-dotnet-aspire.AppHost`

## Generate infrastructure manifests

1) Install Aspirate via DOTNET CLI: `dotnet tool install -g aspirate --prerelease`
2) Run one of the following commands in the heimdall-templates-dotnet-aspire.AppHost directory: `aspirate generate` (k8s) || `aspirate generate --output-format compose` (docker compose)

## Related

- https://learn.microsoft.com/en-us/dotnet/aspire/get-started/aspire-overview
- https://github.com/prom3theu5/aspirational-manifests 
- https://learn.microsoft.com/en-us/dotnet/aspire/deployment/azure/aca-deployment-azd-in-depth?tabs=windows