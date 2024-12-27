using Calabonga.Blazor.AppDefinitions;
using GamesCatalog.DenemeModule;
using GamesCatalog.DenemeModule.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace GamesCatalog.HomeModule;

public class DenemeModuleDefinitions :AppDefinition
{
    public override bool Exported => true;

    public override void ConfigureServices(WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<SingletonService>();
        builder.Services.AddTransient<TransientService>();
        builder.Services.AddScoped<IBlazorModule, DenemeBlazorModule>();
        builder.Services.AddTransient<IRepository, MockGamesRepository>();
    }
}
