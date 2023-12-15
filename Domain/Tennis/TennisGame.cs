﻿namespace Domain.Tennis;

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
            return DetermineDrawResult();
        if (_player1Score >= 4 || _player2Score >= 4)
            return DetermineAdvantageOrWinResult();
        return DetermineOngoingScore();
    }

    private string DetermineDrawResult()
    {
        return new DrawResult(_player1Score, _player2Score).GetScoreAsText();
    }

    private string DetermineAdvantageOrWinResult()
    {
        var minusResult = _player1Score - _player2Score;
        switch (minusResult)
        {
            case 1:
                return "Advantage player1";
            case -1:
                return "Advantage player2";
            case >= 2:
                return "Win for player1";
            default:
                return "Win for player2";
        }
    }

    private string DetermineOngoingScore()
    {
        return GetScoreAsString(_player1Score) + "-" + GetScoreAsString(_player2Score);
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

public abstract class Result
{
    protected int Player1Score = 0;
    protected int Player2Score = 0;

    protected Result(int player1Score, int player2Score)
    {
        Player1Score = player1Score;
        Player2Score = player2Score;
    }

    public abstract string GetScoreAsText();
}

public class DrawResult(int player1Score, int player2Score) : Result(player1Score, player2Score)
{
    public override string GetScoreAsText()
    {
        switch (Player1Score)
        {
            case 0:
                return "Love-All";
            case 1:
                return "Fifteen-All";
            case 2:
                return "Thirty-All";
            default:
                return "Deuce";
        }
    }
}

public class AdvantageOrWinResult : Result
{
    public AdvantageOrWinResult(int player1Score, int player2Score) : base(player1Score, player2Score)
    { }

    public override string GetScoreAsText()
    {
        var minusResult = Player1Score - Player2Score;
        switch (minusResult)
        {
            case 1:
                return "Advantage player1";
            case -1:
                return "Advantage player2";
            case >= 2:
                return "Win for player1";
            default:
                return "Win for player2";
        }
    }
}