namespace Domain.Tennis;

public class TennisGame : ITennisGame
{
    private Player _player1;
    private Player _player2;

    public TennisGame(string player1Name, string player2Name)
    {
        _player1 = new Player(player1Name);
        _player2 = new Player(player2Name);
    }

    public void WonPoint(string playerName)
    {
        if (playerName == _player1.Name)
            _player1.AddPoint();
        else
            _player2.AddPoint();
    }

    public string GetScore()
    {
        return Arbiter
            .DetermineResult(_player1, _player2)
            .GetScoreAsText();
    }
}

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
}