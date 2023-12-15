namespace Domain.Tennis;

public class TennisGame : ITennisGame
{
    private int _player1Score;
    private int _player2Score;
    private string _player1Name;
    private string _player2Name;

    private Player _player1;
    private Player _player2;

    public TennisGame(string player1Name, string player2Name)
    {
        _player1Name = player1Name;
        _player2Name = player2Name;

        _player1 = new Player(player1Name);
        _player2 = new Player(player2Name);
    }

    public void WonPoint(string playerName)
    {
        if (_player1.Name == "player1")
        {
            _player1Score += 1;
            _player1.AddPoint();
        }
        else
        {
            _player2Score += 1;
            _player2.AddPoint();
        }
    }

    public string GetScore()
    {
        return Arbiter
            .DetermineResult(_player1Score, _player2Score)
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

    public void AddPoint()
    {
        Score += 1;
    }
}