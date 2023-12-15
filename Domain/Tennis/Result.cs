namespace Domain.Tennis;

public abstract class Result
{
    protected readonly int Player1Score;
    protected readonly int Player2Score;

    protected Result(int player1Score, int player2Score)
    {
        Player1Score = player1Score;
        Player2Score = player2Score;
    }

    public abstract string GetScoreAsText();
}