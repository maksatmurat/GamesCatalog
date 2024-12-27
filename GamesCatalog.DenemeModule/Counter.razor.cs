using GamesCatalog.Core.Models;
using GamesCatalog.DenemeModule.Repository;
using Microsoft.AspNetCore.Components;

namespace GamesCatalog.DenemeModule;
public partial class Counter
{
    [Inject][CascadingParameter] public AppStyle? Styles { get; set; }
    [Inject] SingletonService? singleton { get; set; }
    [Inject] TransientService? transient { get; set; }
    [Inject] IRepository? repository { get; set; }
    List<Game>? games;



    private int currentCount = 0;
    private void IncrementCount()
    {
        currentCount = singleton!.Value;
        currentCount++;
        singleton.Value = currentCount;
        transient!.Value = currentCount;
    }
    protected override void OnInitialized()
    {
        games = repository!.GetAllGames();
    }
}
