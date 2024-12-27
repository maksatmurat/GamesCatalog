using GamesCatalog.Core.Models;

namespace GamesCatalog.DenemeModule.Repository;

public class MockGamesRepository : IRepository
{
    List<Game> _games;
    public MockGamesRepository()
    {
        _games = new List<Game>()
        {
            new Game()
            {
                Name="Test Rally",
                Genre="Simulator",
                ReleaseDate = new DateTime(2026,05,08)
            },
            new Game()
            {
                Name="HalfLife",
                Genre="RPG",
                ReleaseDate = new DateTime(2025,04,12)
            }
        };
    }
    public List<Game> GetAllGames()
    {
        return _games;
    }
}
