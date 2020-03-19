using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game  //this is where we will bring together the human and additional human and computerAI to deteremine who wins etc. 
    {
        //Member variables (Has A)
        public Player Player1;
        public Player Player2;
        public int Player1Score;
        public int Player2Score;
        public int WinningScore;

        //constructor (Spawner)
        public Game()
        {
            WinningScore = 3;
        }

        //Member Methods (Can Do)
        public void RunGame()
        {
            Instructions();
            TypeOfPlayer();
            

            while (DetermineWinner())
            {
                Player1.playerChoice();
                Player2.playerChoice();
                ComparingGestures();
            }
        }

        public void ComparingGestures() //this is considered a round
        {
            //after gestures are picked
            //this method first
            if (Player1.choice == "Rock" && Player2.choice == "Scissors")
            {
                Player1Score++;
                Console.WriteLine("Player one wins the round");
            }
            else if (Player1.choice == "Rock" && Player2.choice == "Lizard")
            {
                Player1Score++;
                Console.WriteLine("Player one wins the round");
            }
            else if (Player1.choice == "Rock" && Player2.choice == "Paper")
            {
                Player2Score++;
                Console.WriteLine("Player 2 wins the round");
            }
            else if (Player1.choice == "Rock" && Player2.choice == "Spock")
            {
                Player2Score++;
                Console.WriteLine("Player 2 Wins the round");
            }
            else if (Player1.choice == "Paper" && Player2.choice == "Scissors")
            {
                Player2Score++;
                Console.WriteLine("Player 2 wins the round");
            }
            else if (Player1.choice == "Paper" && Player2.choice == "Spock")
            {
                Player1Score++;
                Console.WriteLine("Player 1 wins the round");
            }
            else if (Player1.choice == "Paper" && Player2.choice == "Lizard")
            {
                Player2Score++;
                Console.WriteLine("Player 2 wins the round");
            }
            else if (Player1.choice == "Scissors" && Player2.choice == "Lizard")
            {
                Player1Score++;
                Console.WriteLine("Player 1 wins the round");
            }
            else if (Player1.choice == "Lizard" && Player2.choice == "Spock")
            {
                Player1Score++;
                Console.WriteLine("Player 1 wins the round");
            }
            else if (Player1.choice == "Spock" && Player2.choice == "Scissors")
            {
                Player1Score++;
                Console.WriteLine("Player 1 wins the round");
            }
            else
            {
                Console.WriteLine("This is a tie!");
                Console.ReadLine();
            }
           




        }

        public bool DetermineWinner()
        {
            if (Player1Score == WinningScore) 
            {
                Console.WriteLine("Game is Over Player 1 Wins the game");
                Console.ReadLine();

                return false;
            }
            else if (Player2Score == WinningScore)
            {
                Console.WriteLine("Game is OVer Player 2 Wins the game");
                Console.ReadLine();

                return false;
            }
            else
            {
                return true;
            }


        }

        public void TypeOfPlayer()
        {
            //USER OUT PUT
            //user input
            //this method second
            int choice;
            Console.WriteLine("Enter 1 for human vs ComputerAI or enter 2 for Human vs Human");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Player1 = new Human();
                Player2 = new ComputerAI();
                Console.WriteLine("You have chosen Human vs. Computer");
            }
            else
            {
                Player1 = new Human();
                Player2 = new Human();
                Console.WriteLine("You have chosen Human vs. Human");
            }
        }


        public void Instructions()
        {
            Console.WriteLine("Rock beats Scissors, Scissors beats Paper, Paper beats Rock, Rock beats Lizard, Lizard beats Spock, Spock beats Scissors, Scissors beats Lizard, Lizard beats Paper, Paper beats Spock, Spock beats Rock");
            Console.ReadLine();          
        }
     

    }
}
