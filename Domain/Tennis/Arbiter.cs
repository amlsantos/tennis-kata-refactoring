namespace Domain.Tennis;

public static class Arbiter
{
    public static Result DetermineResult(Player player1, Player player2)
    {
        if (player1.IsTie(player2))
            return new DrawResult(player1.Score, player2.Score);
        if (player1.HasAdvantage(player2) && player1.IsAheadByOne(player2))
            return new AdvantageResult(player1.Score, player2.Score);
        if (player1.HasAdvantage(player2))
            return new WinResult(player1.Score, player2.Score);
        return new OngoingScore(player1.Score, player2.Score);
    }
}