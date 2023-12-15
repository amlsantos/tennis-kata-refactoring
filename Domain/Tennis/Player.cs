namespace Domain.Tennis;

public class Player
{
    public int Score { get; private set; }
    public string Name { get; }

    public Player(string name)
    {
        Name = name;
        Score = 0;
    }

    public void AddPoint() => Score += 1;

    public bool IsTie(Player otherPlayer) => Score == otherPlayer.Score;

    public bool HasAdvantage(Player otherPlayer)
    {
        return Score >= 4 || otherPlayer.Score >= 4;
    }

    public bool IsAheadByOne(Player otherPlayer)
    {
        return Math.Abs(Score - otherPlayer.Score) == 1;
    }
}