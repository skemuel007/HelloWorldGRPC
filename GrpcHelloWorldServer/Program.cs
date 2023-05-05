using GrpcHelloWorldServer.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGrpcService<HelloWorldService>();

app.Run();
