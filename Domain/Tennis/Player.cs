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

    public bool IsTie(Player otherPlayer)
    {
        return Score == otherPlayer.Score;
    }
}