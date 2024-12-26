using Calabonga.Blazor.AppDefinitions;
using System.Reflection;

namespace GamesCatalog.WebApp.Components;

public partial class Routes
{
    public IEnumerable<Assembly> Modules => ModuleDefinitions.Instance.Assemblies;
}
