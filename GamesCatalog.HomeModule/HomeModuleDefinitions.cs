using Calabonga.Blazor.AppDefinitions;
using GamesCatalog.Core.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace GamesCatalog.HomeModule;

public class HomeModuleDefinitions :AppDefinition
{
    public override bool Exported => true;

    public override void ConfigureServices(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IBlazorModule, HomeBlazorModule>();
        builder.Services.AddScoped<AppStyle>();
    }
}
