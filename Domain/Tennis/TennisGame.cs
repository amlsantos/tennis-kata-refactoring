﻿namespace Domain.Tennis;

public class TennisGame : ITennisGame
{
    private int player1Score = 0;
    private int player2Score = 0;
    private string player1Name;
    private string player2Name;

    public TennisGame(string player1Name, string player2Name)
    {
        this.player1Name = player1Name;
        this.player2Name = player2Name;
    }

    public void WonPoint(string playerName)
    {
        if (playerName == "player1")
            player1Score += 1;
        else
            player2Score += 1;
    }

    public string GetScore()
    {
        if (player1Score == player2Score) // tie
            return DetermineDrawResult();
        else if (player1Score >= 4 || player2Score >= 4) // advantage or win
            return DetermineAdvantageOrWinResult();
        else // ongoing
            return DetermineOngoingScore();
    }

    private string DetermineDrawResult()
    {
        switch (player1Score)
        {
            case 0:
                return "Love-All";
            case 1:
                return "Fifteen-All";
            case 2:
                return "Thirty-All";
            default:
                return "Deuce";
        }
    }

    private string DetermineAdvantageOrWinResult()
    {
        var minusResult = player1Score - player2Score;
        switch (minusResult)
        {
            case 1:
                return "Advantage player1";
            case -1:
                return "Advantage player2";
            case >= 2:
                return "Win for player1";
            default:
                return "Win for player2";
        }
    }

    private string DetermineOngoingScore()
    {
        var score = string.Empty;
        for (var i = 1; i < 3; i++)
        {
            var tempScore = 0;
            if (i == 1)
            {
                tempScore = player1Score;
            }
            else
            {
                score += "-";
                tempScore = player2Score;
            }

            switch (tempScore)
            {
                case 0:
                    score += "Love";
                    break;
                case 1:
                    score += "Fifteen";
                    break;
                case 2:
                    score += "Thirty";
                    break;
                case 3:
                    score += "Forty";
                    break;
            }
        }

        return score;
    }
}