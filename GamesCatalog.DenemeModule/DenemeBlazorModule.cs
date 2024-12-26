using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components.Routing;

namespace GamesCatalog.HomeModule;

public class DenemeBlazorModule : BlazorModule
{
    public override int OrderIndex => 2;
    public override string Title => "Deneme";

    public override string Description => "Deneme Page";

    public override string Route => "/deneme";
}