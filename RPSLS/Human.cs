using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player  //this is where the human class (child of the player class) is being inherited
    {
        public override void playerChoice() //this is where we are inheriting playerchoice but overriding the abstract from player to use how we want to because WE have to since its abstract. 
        {
            Console.WriteLine("Choose your geture"); //simply writing to the console for the user "Choose your gesture"

            for (int i = 0; i < 5; i++) // using a for loop to utilize player choice staring from 0 and going no further then 5 as a choice. ++ is indicating we are going up one each time. 
            {
                Console.WriteLine($"Press {i + 1} for {Gestures[i]}"); // this is where we right to the console of the users choice +1 because the line starts at zero and not one, then we have the gesture as a choice called i.
            }
            int userInput = int.Parse(Console.ReadLine()); //converting userInput from a string to a number, need to use int.Parse to do that. becaue we declared choice as a string variable

            choice = Gestures[userInput - 1];  //this is where when the user puts in a number it is subtracted by 1 because the line starts from 0 and not 1. 


        }
    }
}
