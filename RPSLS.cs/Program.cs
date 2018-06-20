using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you ready to play?");

            if (Console.ReadLine().ToLower() == "yes")
            {
                Console.WriteLine("Player 1, enter your selection here. You may choose rock, paper, scissors, lizard, or spock.");
                string userOneInputSelections = Console.ReadLine();
                PlayerOneInputSelections playerOneChoiceAnswer = new PlayerOneInputSelections(userOneInputSelections);

                Console.WriteLine("Player 2, enter your selection here. You may choose rock, paper, scissors, lizard, or spock.");
                string userTwoInputSelections = Console.ReadLine().ToLower();
                PlayerTwoInputSelections playerTwoChoiceAnswer = new PlayerTwoInputSelections(userTwoInputSelections);
                Console.ReadLine();
            }
        }
    }
}
