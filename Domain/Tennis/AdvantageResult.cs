namespace Domain.Tennis;

public class AdvantageResult(int player1Score, int player2Score) : Result(player1Score, player2Score)
{
    public override string GetScoreAsText()
    {
        return Player1Score > Player2Score ? 
            "Advantage player1" : 
            "Advantage player2";
    }
}

public class WinResult(int player1Score, int player2Score) : Result(player1Score, player2Score)
{
    public override string GetScoreAsText()
    {
        return Player1Score > player2Score ? 
            "Win for player1" : 
            "Win for player2";
    }
}