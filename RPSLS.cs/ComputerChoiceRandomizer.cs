using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.cs
{
    class DisplayRandomNumber
    {
        static void Number(string[] args)
        {
            MakeRandomNumber numberGenerator = new MakeRandomNumber();
            int randomNumberIs = numberGenerator.RandomNumber(1, 5);
        }
    }

    public class MakeRandomNumber
    {
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }



}