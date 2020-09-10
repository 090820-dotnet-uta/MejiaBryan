using System;
using System.Collections.Generic;

namespace RPS_Game_NoDB
{
    public class Player
    {
        public string Name { get; set; } = "null";

        public List<Game> games = new List<Game>();
        public Dictionary<string, int> record = new Dictionary<string, int>()
        {
            {"wins", 0},
            {"losses", 0}
        };

        public static Choice getPlayerChoice(){
            int int_input;
                while(true){
                    Console.WriteLine("Please select an action [0:Rock, 1:Paper, 2:Scissors]");
                    string input = Console.ReadLine();
                    bool isInt = int.TryParse(input, out int_input);
                    if (isInt && (int_input >= 0 && int_input <= 2)) break;
                    Console.WriteLine("\nThat was not a valid entry.");
                }
                return (Choice)int_input;
        }


        public static void printPlayer(Player player){
            System.Console.WriteLine($"This players name is {player.Name} and he has {player.record["wins"]} wins and {player.record["losses"]} losses");
            System.Console.WriteLine("Games player has played:");
            Game.printGames(player.games);
            System.Console.WriteLine("Player win/loss record:");
            foreach(KeyValuePair<String, int> kvp in player.record){
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            }
        }
        
        public static void printPlayers(List<Player> players){
            foreach(Player player in players){
                Player.printPlayer(player);
            }
        }
    }
}