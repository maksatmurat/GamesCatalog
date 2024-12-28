using Calabonga.Blazor.AppDefinitions;

namespace GameCatalog.RspGameModule;

public class RspGameBlazorModule : BlazorModule
{
    public override int OrderIndex => 2;
    public override string Title => "Rspminigame";

    public override string Description => "Rsp Minigame";

    public override string Route => "/rsp";
}
