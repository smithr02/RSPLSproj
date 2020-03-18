using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class ComputerAI : Player
    {
        public override void playerChoice()
        {
            Random computerChoice = new Random();
            int chosenGesture = computerChoice.Next(0, 5);
            choice = Gestures[chosenGesture];
        }

        

    }
}
