namespace Domain.Tennis;

public interface ITennisGame
{
    void WonPoint(string playerName);
    string GetScore();
}