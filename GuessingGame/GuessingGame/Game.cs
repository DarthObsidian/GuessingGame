using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Game
    {
        internal int currentNum { get; set; }

        internal void RunGame()
        {

        }

        internal int CheckGuess(int _num)
        {
            if (_num == currentNum)
                return 0;
            else if (_num > currentNum)
                return 1;
            else
                return -1;
        }

        internal int GetRandomNumber()
        {
            Random random = new();
            return random.Next(0, 9999);
        }
    }
}
