namespace Domain.Tennis;

public static class Arbiter
{
    public static Result DetermineResult(int player1Score, int player2Score, Player player1, Player player2)
    {
        if (IsTie(player1Score, player2Score, player1, player2))
            return new DrawResult(player1Score, player2Score);
        if (HasAdvantage(player1Score, player2Score, player1, player2) && IsAheadByOne(player1Score, player2Score, player1, player2))
            return new AdvantageResult(player1Score, player2Score);
        if (HasAdvantage(player1Score, player2Score, player1, player2))
            return new WinResult(player1Score, player2Score);
        return new OngoingScore(player1Score, player2Score);
    }

    private static bool IsTie(int player1Score, int player2Score, Player player1, Player player2)
    {
        return player1.Score == player2.Score;
        return player1Score == player2Score;
    }

    private static bool HasAdvantage(int player1Score, int player2Score, Player player1, Player player2)
    {
        return player1.Score >= 4 || player2.Score >= 4;
        return player1Score >= 4 || player2Score >= 4;
    }

    private static bool IsAheadByOne(int player1Score, int player2Score, Player player1, Player player2)
    {
        return Math.Abs(player1.Score - player2.Score) == 1;
        return Math.Abs(player1Score - player2Score) == 1;
    }
}