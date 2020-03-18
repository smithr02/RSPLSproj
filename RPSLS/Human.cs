using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public override void playerChoice()
        {
            Console.WriteLine("Choose your geture");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Press {i + 1} for {Gestures[i]}");
            }
            int userInput = int.Parse(Console.ReadLine());

            choice = Gestures[userInput - 1];


        }
    }
}
