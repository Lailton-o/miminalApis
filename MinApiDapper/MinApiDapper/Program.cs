using MinApiDapper.Endpoints;
using MinApiDapper.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.AddPersistence();

var app = builder.Build();

app.MapTarefasEndpoints();

app.UseSwagger();
app.UseSwaggerUI(x => { });

app.Run();
