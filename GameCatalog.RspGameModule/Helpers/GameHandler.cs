namespace GameCatalog.RspGameModule.Helpers;

public class GameHandler
{
    public RSPOptions Choose { get; set; }
    public RSPOptions WinCondition { get;set; }
    public RSPOptions LoosCondition { get; set; }
    public string? Image  { get; set; }

    public GameState GameResult(GameHandler opponent)
    {
        if (Choose == opponent.Choose)
            return GameState.Draw;
        else if (LoosCondition == opponent.Choose)
            return GameState.Loss;
        return GameState.Victory;
    }
}

