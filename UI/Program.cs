using Domain.Tennis;

var player1 = "player1";
var player2 = "player2";

var game = new TennisGame(player1, player2);
var score = game.GetScore();
Console.WriteLine(score);

game.WonPoint(player2);
score = game.GetScore();
Console.WriteLine(score);

game.WonPoint(player1);
score = game.GetScore();
Console.WriteLine(score);

game.WonPoint(player1);
score = game.GetScore();
Console.WriteLine(score);

game.WonPoint(player1);
score = game.GetScore();
Console.WriteLine(score);

game.WonPoint(player1);
score = game.GetScore();
Console.WriteLine(score);