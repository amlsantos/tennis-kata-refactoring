namespace Domain.Tennis;

public class TennisGame : ITennisGame
{
    private int _player1Score;
    private int _player2Score;
    private string _player1Name;
    private string _player2Name;

    public TennisGame(string player1Name, string player2Name)
    {
        _player1Name = player1Name;
        _player2Name = player2Name;
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