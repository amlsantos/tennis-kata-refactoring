namespace Domain.Tennis;

public static class Arbiter
{
    public static Result DetermineResult(int player1Score, int player2Score)
    {
        if (IsTie(player1Score, player2Score))
            return new DrawResult(player1Score, player2Score);
        if (HasAdvantage(player1Score, player2Score) && IsAheadByOne(player1Score, player2Score))
            return new AdvantageResult(player1Score, player2Score);
        if (HasAdvantage(player1Score, player2Score))
            return new WinResult(player1Score, player2Score);
        return new OngoingScore(player1Score, player2Score);
    }

    private static bool IsTie(int player1Score, int player2Score)
    {
        return player1Score == player2Score;
    }

    private static bool HasAdvantage(int player1Score, int player2Score)
    {
        return player1Score >= 4 || player2Score >= 4;
    }

    private static bool IsAheadByOne(int player1Score, int player2Score)
    {
        return Math.Abs(player1Score - player2Score) == 1;
    }
}