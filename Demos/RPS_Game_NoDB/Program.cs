using System;
using System.Collections.Generic;
using System.Linq;

namespace RPS_Game_NoDB
{
    public enum Choice
    {
        Rock,//can be accessed with a 0
        Paper,//can be accessed with a 1
        Scissors//can be accessed with a 2
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            List<Game> games = new List<Game>();
            List<Round> rounds = new List<Round>();
            int choice;
            Player computer = new Player() { Name = "Computer" };//instantiate a Player and give a value to the Name all at once.
            players.Add(computer);
            int gameCounter = 1;

            do//game loop
            {
                System.Console.WriteLine($"\n\t\tThis is game #{gameCounter++}\n\n");

                //get a choice from the user (play or quit)
                bool inputInt;
                do//prompt loop
                {
                    System.Console.WriteLine("Please choose 1 for Play or 2 for Quit");
                    string input = Console.ReadLine();
                    inputInt = int.TryParse(input, out choice);
                } while (!inputInt || choice <= 0 || choice >= 3);//end of promt loop

                if (choice == 2)//if the user chose 2, break out of the game.
                {
                    break;
                }
                //System.Console.WriteLine("made it out of the loop");

                //get the player name
                System.Console.WriteLine("What is your name?");
                string playerName = Console.ReadLine();
                Player p1 = new Player();//p1 is null here.

                // check the list of players to see if this payer is a returning player.
                foreach (Player item in players)
                {
                    if (item.Name == playerName)
                    {
                        p1 = item;
                        System.Console.WriteLine("You are a returning player");
                        break;//end the foreach loop
                    }
                }

                if (p1.Name == "null")//means the players name was not found above
                {
                    p1.Name = playerName;
                    players.Add(p1);
                }

                Game game = new Game();// create a game
                game.Player1 = p1;//
                game.Computer = computer;//

                Random rand = new Random();

                //play rounds till one player has 2 wins
                //assign the winner to the game and check that property to break out of the loop.
                while (game.winner.Name == "null")
                {
                    Round round = new Round();//declare a round for this iteration
                    round.game = game;// add the game to this round
                    round.player1 = p1;// add user (p1) to this round
                    round.Computer = computer;// add computer to this round

                    //get the choices for the 2 players
                    //insert the players choices directly into the round
                    round.p1Choice = Player.getPlayerChoice();//this will give a random number starting at 0 to arg-1;
                    round.ComputerChoice = (Choice)rand.Next(3);

                    //check the choices to see who won.
                    if (round.p1Choice == round.ComputerChoice)
                    {
                        round.Outcome = 0; // it’s a tie . the default is 0 so this line is unnecessary.
                        System.Console.WriteLine("this round was a tie");
                    }
                    else if ((int)round.p1Choice == ((int)round.ComputerChoice + 1) % 3)
                    { //If users pick is one more than the computer’s, user wins
                        round.Outcome = 1;
                    }
                    else
                    { //If it’s not a tie and p1 didn’t win, then computer wins.
                        round.Outcome = 2;
                    }

                    game.rounds.Add(round);//add this round to the games List of rounds

                    //search the game.rounds List<> to see if one player has 2 wins
                    //if not loop to another round
                    int numP1Wins = game.rounds.Count(x => x.Outcome == 1);//get nhow many rounds p1 has won.
                    int numComputerWins = game.rounds.Count(x => x.Outcome == 2);//get nhow many rounds p1 has won.

                    //assign the winner to the game and increment wins and losses for both
                    System.Console.WriteLine($"\tp1wins => {numP1Wins} \n\tcomputer wins {numComputerWins}");
                    if (numP1Wins == 2)
                    {
                        game.winner = p1;
                        p1.record["wins"]++;//increments wins and losses.
                        computer.record["losses"]++;//increments wins and losses.
                    }
                    else if (numComputerWins == 2)
                    {
                        game.winner = computer;
                        p1.record["losses"]++;//increments wins and losses.
                        computer.record["wins"]++;//increments wins and losses.
                    }


                }//end of rounds loop

                games.Add(game);
                p1.games.Add(game);
                computer.games.Add(game);



                //play rounds till one player has 2 wins
                //record each round into the game

                //record the game

                //increment wins/losses for each player

                //print out the game results - rounds data



            } while (choice != 2);//end of game loop


            PrintAllCurrentData(games, players, rounds);




            //on quitting....
            //print out the win.loss record for all players

        }//end of main

        public static void PrintAllCurrentData(List<Game> games, List<Player> players, List<Round> rounds)
        {  
            Console.WriteLine("\n___________________GAMES_______________________\n");
            Game.printGames(games);
            Console.WriteLine("\n___________________PLAYERS_______________________\n");
            Player.printPlayers(players);
            Console.WriteLine("\n___________________ROUNDS_______________________\n");
            Round.printRounds(rounds);

        }

    }//end of program
}//end of namaespace
