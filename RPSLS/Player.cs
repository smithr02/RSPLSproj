using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        public string name;
        public string choice;

        public List<string> Gestures = new List<string>();
        public Player()
        {
            Gestures.Add("Scissors");
            Gestures.Add("Paper");
            Gestures.Add("Rock");
            Gestures.Add("Spock");
            Gestures.Add("Lizard");
        }

        public abstract void playerChoice();

      
        

    }
}
