namespace Domain.Tennis;

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
        var score = "";
        if (player1Score == player2Score) // tie
        {
            score = DetermineDrawResult();
        }
        else if (player1Score >= 4 || player2Score >= 4) // advantage or win
        {
            score = DetermineAdvantageOrWinResult();
        }
        else // 
        {
            score = DetermineOngoingScore(score);
        }

        return score;
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
        string score;
        var minusResult = player1Score - player2Score;
        switch (minusResult)
        {
            case 1:
                score = "Advantage player1";
                break;
            case -1:
                score = "Advantage player2";
                break;
            case >= 2:
                score = "Win for player1";
                break;
            default:
                score = "Win for player2";
                break;
        }
        return score;
    }

    private string DetermineOngoingScore(string score)
    {
        var tempScore = 0;
        for (var i = 1; i < 3; i++)
        {
            if (i == 1) tempScore = player1Score;
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