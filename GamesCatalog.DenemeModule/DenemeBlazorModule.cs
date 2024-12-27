using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components.Routing;

namespace GamesCatalog.HomeModule;

public class DenemeBlazorModule : BlazorModule
{
    public override int OrderIndex => 2;
    public override string Title => "counter";

    public override string Description => "counter Page";

    public override string Route => "/counter";
}