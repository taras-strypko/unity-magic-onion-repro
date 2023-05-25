using System.Net;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();       // Add this line(Grpc.AspNetCore)
builder.Services.AddMagicOnion(); // Add this line(MagicOnion.Server)

builder.WebHost.UseKestrel(opts =>
{
    opts.Listen(IPAddress.Any, 5001, opts => opts.Protocols = Microsoft.AspNetCore.Server.Kestrel.Core.HttpProtocols.Http2);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseRouting();

app.MapMagicOnionService(); // Add this line

app.Run();
