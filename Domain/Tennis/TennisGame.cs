namespace Domain.Tennis;

public class TennisGame : ITennisGame
{
    private int _player1Score = 0;
    private int _player2Score = 0;
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
        if (_player1Score == _player2Score)
            return new DrawResult(_player1Score, _player2Score).GetScoreAsText();
        if (_player1Score >= 4 || _player2Score >= 4)
            return new AdvantageOrWinResult(_player1Score, _player2Score).GetScoreAsText();
        return new OngoingScore(_player1Score, _player2Score).GetScoreAsText();
    }
}

public class Arbiter
{
    public static Result DetermineResult(int player1Score, int player2Score)
    {
        throw new NotImplementedException();
    }
}