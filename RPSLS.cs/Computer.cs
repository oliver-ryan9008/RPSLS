using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.cs
{
    public class Computer : Player
    {
        public Computer()
        {
            
        }

        public override void GetPlayerChoice()
        {
            Random random = new Random();
            choice = random.Next(0, 4);
        }
    }
}
