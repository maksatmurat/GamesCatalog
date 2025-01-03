using Calabonga.Blazor.AppDefinitions;
using GamesCatalog.WebApp.Components;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.AddBlazorModulesDefinitions("Modules", typeof(App));

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseDefinitions();

app.Run();
