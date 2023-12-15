namespace Domain.Tennis;

public class OngoingScore : Result
{
    public OngoingScore(int player1Score, int player2Score) : base(player1Score, player2Score)
    { }

    public override string GetScoreAsText()
    {
        return GetScoreAsString(Player1Score) + "-" + GetScoreAsString(Player2Score);
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