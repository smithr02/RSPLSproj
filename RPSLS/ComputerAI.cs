using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class ComputerAI : Player //this is where we have computerAI as the child class its inheriting the player class
    {
        public override void playerChoice() // overrided method from parent class
        {
            Random computerChoice = new Random();  //created new object called computerChoice
            int chosenGesture = computerChoice.Next(0, 5); // 
            choice = Gestures[chosenGesture];
        }

        

    }
}
