namespace Domain.Tennis;

public class AdvantageResult(int player1Score, int player2Score) : Result(player1Score, player2Score)
{
    public override string GetScoreAsText()
    {
        var minusResult = Player1Score - Player2Score;
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
}

public class WinResult(int player1Score, int player2Score) : Result(player1Score, player2Score)
{
    public override string GetScoreAsText()
    {
        var minusResult = Player1Score - Player2Score;
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
}