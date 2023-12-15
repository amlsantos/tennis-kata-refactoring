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
        if (player1Score == player2Score)
            return DetermineDrawResult();
        if (player1Score >= 4 || player2Score >= 4)
            return DetermineAdvantageOrWinResult();
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
        return GetScoreAsString(player1Score) + "-" + GetScoreAsString(player2Score);
    }

    private string GetScoreAsString(int tempScore)
    {
        switch (tempScore)
        {
            case 0:
                return "Love";
            case 1:
                return "Fifteen";
            case 2:
                return "Thirty";
            case 3:
                return "Forty";
            default:
                return string.Empty;
        }
    }
}