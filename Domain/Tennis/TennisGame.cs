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
        if (playerName == "player1")
            _player1Score += 1;
        else
            _player2Score += 1;
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
    public int Score { get; init; }
    public string Name { get; init; }

    public Player(string name)
    {
        Name = name;
        Score = 0;
    }
}