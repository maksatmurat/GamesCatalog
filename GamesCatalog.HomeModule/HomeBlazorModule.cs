using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components.Routing;

namespace GamesCatalog.HomeModule;

public class HomeBlazorModule : BlazorModule
{
    public override int OrderIndex => 1;
    public override string Title => "Home";

    public override string Description => "Home Page";

    public override string Route => "/";
    public override NavLinkMatch Match => NavLinkMatch.All;
}