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
        var result = Arbiter.DetermineResult(_player1, _player2);
        return result.GetScoreAsText();
    }
}