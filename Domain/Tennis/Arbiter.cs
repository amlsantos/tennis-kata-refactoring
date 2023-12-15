﻿namespace Domain.Tennis;

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
        return player1.Score == player2.Score;
    }

    private static bool HasAdvantage(Player player1, Player player2)
    {
        return player1.Score >= 4 || player2.Score >= 4;
    }

    private static bool IsAheadByOne(Player player1, Player player2)
    {
        return Math.Abs(player1.Score - player2.Score) == 1;
    }
}