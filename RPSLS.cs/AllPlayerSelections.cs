using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.cs
{
    class AllPlayerSelections
    {
        //member variables
        public string playerOneSelection;
        public string playerTwoSelection;
        public string computerSelection;
        public string[] choices = new string[5];

        // constructor
        public AllPlayerSelections()
        {
            
        }

        public void PossibleChoices()
        {
            choices[0] = "Rock";
            choices[1] = "Paper";
            choices[2] = "Scissors";
            choices[3] = "Lizard";
            choices[4] = "Spock";
        }

        // member methods
    }
}
