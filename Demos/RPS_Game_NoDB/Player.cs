using System;
using System.Collections.Generic;

namespace RPS_Game_NoDB
{
    public class Player
    {
        public string Name { get; set; } = "null";

        //public string name;
        //private string name;
        // public void SetName(string name){
        //     this.name = name;
        // }



        public List<Game> games = new List<Game>();
        public Dictionary<string, int> record = new Dictionary<string, int>()
        {
            {"wins", 0},
            {"losses", 0}
        };
        //"wins" = 2
        //"losses" = 3
        //record."wins"++;

        public static Choice getPlayerChoice(){
            int int_input;
                while(true){
                    Console.WriteLine("Please select action [0:Rock, 1:Paper, 2:Scissors]");
                    string input = Console.ReadLine();
                    bool isInt = int.TryParse(input, out int_input);
                    if (isInt && (int_input >= 0 && int_input <= 2)) break;
                }
                return (Choice)int_input;
        }
    }
}