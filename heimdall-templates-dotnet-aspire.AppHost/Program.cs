var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.heimdall_templates_dotnet_aspire_ApiService>("apiservice");

builder.AddProject<Projects.heimdall_templates_dotnet_aspire_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
