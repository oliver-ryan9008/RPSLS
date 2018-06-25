using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.cs
{
    class Game
    {



        Player playerOne;
        Player playerTwo;

        public void Run()
        {
            StartGame();
            RunRound();

        }
        public void StartGame()
        {
            Console.WriteLine("Enter 1 for single player, or enter 2 for multiplayer.");
            string gameType = Console.ReadLine().ToLower();

            switch (gameType)
            {
                case "1":
                    playerOne = new Human();
                    playerTwo = new Computer();
                    break;
                case "2":
                    playerOne = new Human();
                    playerTwo = new Human();
                    break;
                default:
                    Console.WriteLine("You've entered nothing valuable. Please read better.");

                    break;
            }


        }
        public void RunRound()
        {
            playerOne.MakePlayerChoice();
            Console.ReadLine();
            playerTwo.MakePlayerChoice();
            Console.ReadLine();
        }
    }
}
