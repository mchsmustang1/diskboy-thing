var builder = WebApplication.CreateBuilder(args);

var supportedVersions = (builder.Configuration["DISKBOY_SUPPORTED_VERSIONS"] ?? "0:1")
    .Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
    .ToHashSet(StringComparer.Ordinal);

var app = builder.Build();

app.MapGet(
    "/headlessbox/query/v2/version",
    (string? version) => supportedVersions.Contains(version ?? string.Empty)
        ? Results.Text("ok", "text/plain")
        : Results.Text("this version is outdated or does not exist!", "text/plain"));

app.Run();
