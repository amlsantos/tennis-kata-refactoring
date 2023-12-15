namespace Domain.Tennis;

public static class Arbiter
{
    public static Result DetermineResult(Player player1, Player player2)
    {
        if (IsTie(player1, player2))
            return new DrawResult(player1.Score, player2.Score);
        if (HasAdvantage(player1, player2) && IsAheadByOne(player1, player2))
            return new AdvantageResult(player1.Score, player2.Score);
        if (HasAdvantage(player1, player2))
            return new WinResult(player1.Score, player2.Score);
        return new OngoingScore(player1.Score, player2.Score);
    }

    private static bool IsTie(Player player1, Player player2)
    {
        return player1.IsTie(player2);
    }

    private static bool HasAdvantage(Player player1, Player player2)
    {
        return player1.HasAdvantage(player2);
    }

    private static bool IsAheadByOne(Player player1, Player player2)
    {
        return player1.IsAheadByOne(player2);
    }
}