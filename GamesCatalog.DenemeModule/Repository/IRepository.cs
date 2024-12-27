using GamesCatalog.Core.Models;

namespace GamesCatalog.DenemeModule.Repository;

public interface IRepository
{
    List<Game> GetAllGames();

}
