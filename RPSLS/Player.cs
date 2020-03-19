using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        public string name; //this is where we declared string as name
        public string choice; //this is where we declare string as choice

        public List<string> Gestures = new List<string>(); //creating a string as a list called "gestures" which = the newly created object that is stored as "gestures"
        public Player() //this is the consturctor needed to add our gestures that we make. i.e. "rock, paper etc..."
        {
            Gestures.Add("Rock");
            Gestures.Add("Scissors"); //using our created list "gesture" and adding in our string names
            Gestures.Add("Paper");
            Gestures.Add("Lizard");
            Gestures.Add("Spock");
        }

        public abstract void playerChoice(); // this is where we start the parent method of playerCHoice, its abstract and WILL be used by the inherited classes, Human and Computer AI. 

      
        

    }
}
