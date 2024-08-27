using GameStore.Api.EndPoints;
using GameStore.Api.Entities;
using GameStore.Api.Repositories;
using Microsoft.Extensions.FileSystemGlobbing;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Services.AddSingleton<IGamesRepository, ImMemGamesRepository>();
app.MapGamesEndpoints();




app.Run();
