namespace Domain.Tennis;

public class DrawResult(int player1Score, int player2Score) : Result(player1Score, player2Score)
{
    public override string GetScoreAsText()
    {
        switch (Player1Score)
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
}