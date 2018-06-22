using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.cs
{
    public class Player
    {
        //member variables (has a)
        public string name;
        //public int choice;
        public int gesture;
        public int choice;

        // constructor (things the class needs)
        public Player()
        {
            
        }

        

        public string PossibleGestures()
        {
            List<string> gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Spock");
            gestures.Add("Lizard");
            

            return gestures[choice];
        }

        public virtual int GetPlayerChoice()
        {
            int choice = 0;
            Console.WriteLine("Make a selection for your gesture. You may choose Rock, Paper, Scissors, Spock, or Lizard.");
            string playerSelection = Console.ReadLine();
            playerSelection.ToLower();

            switch (playerSelection)
            {
                case "rock":
                    choice = 0;
                    break;
                case "paper":
                    choice = 1;
                    break;
                case "scissors":
                    choice = 2;
                    break;
                case "spock":
                    choice = 3;
                    break;
                case "lizard":
                    choice = 4;
                    break;
            }
            return choice;
        }

    }
}
