using System;
using System.Collections.Generic;

namespace RPS_Game_NoDB
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Computer { get; set; }
        public List<Round> rounds = new List<Round>();
        public Player winner = new Player();

        public static void printGame(Game game){
            System.Console.WriteLine($"Game:\nPlayer1 Name => {game.Player1.Name}\ncomputer Name => {game.Computer.Name}\n game winner => {game.winner.Name}");
            System.Console.WriteLine($"\t--- Here are the games rounds --- ");
            Round.printRounds(game.rounds);
        }

        public static void printGames(List<Game> games){
            foreach(Game game in games){
                Game.printGame(game);
            }
        }

    }
}