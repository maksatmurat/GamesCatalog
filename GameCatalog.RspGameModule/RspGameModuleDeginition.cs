using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace GameCatalog.RspGameModule;

public class RspGameModuleDeginition : AppDefinition
{
    public override bool Exported => true;

    public override void ConfigureServices(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IBlazorModule, RspGameBlazorModule>();

    }

    public override void ConfigureApplication(WebApplication app1)
    {
        app1.UseStaticFiles();
        app1.UseStaticFiles(new StaticFileOptions
        {
            FileProvider = new PhysicalFileProvider(
           Path.Combine(AppContext.BaseDirectory, "C:\\Users\\Maksat\\source\\repos\\GamesCatalog\\GameCatalog.RspGameModule", "wwwroot")),
            RequestPath = "/RspGame"
        });
    }
}