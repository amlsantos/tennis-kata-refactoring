namespace Domain.Tennis;

public static class Arbiter
{
    public static Result DetermineResult(int player1Score, int player2Score)
    {
        if (player1Score == player2Score)
            return new DrawResult(player1Score, player2Score);
        if (player1Score >= 4 || player2Score >= 4)
            return new AdvantageOrWinResult(player1Score, player2Score);
        return new OngoingScore(player1Score, player2Score);
    }
}