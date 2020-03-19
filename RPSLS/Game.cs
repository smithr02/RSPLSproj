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

        }

        //Member Methods (Can Do)
        public void RunGame()
        {
            Instructions();
            Player1.playerChoice();
        }

        public void ComparingGestures() //this is considered a round
        {
            //after gestures are picked
            //this method first
            if (Player1.choice == "Rock" && Player2.choice == "Scissors")
            {
                Player1Score++;
            }
            else if (Player1.choice == "Rock" && Player2.choice == "Lizard")
            {
                Player1Score++;
            }
            else if (Player1.choice == "Rock" && Player2.choice == "Paper")
            {
                Player2Score++;
            }
            else if (Player1.choice == "Rock" && Player2.choice == "Spock")
            {
                Player2Score++;
            }
            else if (Player1.choice == "Paper" && Player2.choice == "Scissors")
            {
                Player2Score++;
            }
            else if (Player1.choice == "Paper" && Player2.choice == "Spock")
            {
                Player1Score++;
            }
            else if (Player1.choice == "Paper" && Player2.choice == "Lizard")
            {
                Player2Score++;
            }
            else if (Player1.choice == "Scissors" && Player2.choice == "Lizard")
            {
                Player1Score++;
            }
            else if (Player1.choice == "Lizard" && Player2.choice == "Spock")
            {
                Player1Score++;
            }
            else if (Player1.choice == "Spock" && Player2.choice == "Scissors")
            {
                Player1Score++;
            }
            else
            {
                Console.WriteLine("This is a tie!");
            }
           




        }

        public void DetermineWinner()
        {

        }

        public void TypeOfPlayer()
        {
            //USER OUT PUT
            //user input
            //this method second
           // int choice;
           // Console.WriteLine("Enter 1 for human vs ComputerAI or enter 2 for Human vs Human");
            //choice = int.Parse(Console.ReadLine());
           // if (choice == 1)
            //{
               // Player1 = new Human();
               // Player2 = new ComputerAI();
           // }
           // else
            //{
               // Player1 = new Human();
               // Player2 = new Human();
           // }

            int choice1; //created int of choice1
            int choice2;
            Console.WriteLine("Enter 1 for human and enter 2 for ComputerAI"); 
            choice1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 1 for human and enter 2 for ComputerAI");
            choice2 = int.Parse(Console.ReadLine()); // converting string to a int

            if (choice1 == 1)   // created an if statement where if choice 1 is equal to 1 would be a human and choice 2 would be computerAI
            {
                Player1 = new Human();
            }
            else
            {
                Player1 = new ComputerAI();
            }
            if (choice2 == 1) //same as above comment but for choice 2
            {
                Player2 = new Human();
            }
            else
            {
                Player2 = new ComputerAI();
            }

        }


        public void Instructions()
        {
            //whenever
        }
     

    }
}
