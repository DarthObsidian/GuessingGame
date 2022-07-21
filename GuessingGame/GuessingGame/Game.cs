using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Game
    {
        internal void RunGame()
        {

        }

        internal int GetRandomNumber()
        {
            Random random = new();
            return random.Next(0, 9999);
        }
    }
}
