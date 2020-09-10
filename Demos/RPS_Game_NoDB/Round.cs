using System;
using System.Collections.Generic;

namespace RPS_Game_NoDB
{
    public class Round
    {
        public Player player1 { get; set; }
        public Player Computer { get; set; }
        public Choice p1Choice { get; set; }
        public Choice ComputerChoice { get; set; }
        public int Outcome { get; set; } = 0; //0 == Tie, 1 ==P1 wins, 2 == computer wins
        public Game game { get; set; }
    
        public static void printRound(Round round){
            System.Console.WriteLine($"player1 => {round.player1.Name}, p1 choice => {round.p1Choice}");
            System.Console.WriteLine($"player2 => {round.Computer.Name}, computer choice => {round.ComputerChoice}");
            System.Console.WriteLine($"the Outcome of this round is =>{round.Outcome}");
        }

        public static void printRounds(List<Round> rounds){
            foreach(Round round in rounds){
                Round.printRound(round);
            }
        }
    }
}