using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Game
    {
        internal int CurrentNum { get; set; }
        internal int TotalGuesses { get; set; }

        int lastGuess;
        int currentGuess;

        internal void RunGame()
        {

        }

        internal bool ValidateInput(string _input)
        {
            return int.TryParse(_input, out currentGuess);
        }

        internal int CheckGuess(int _num)
        {
            CountGuesses(_num);

            if (_num == CurrentNum)
                return 0;
            else if (_num > CurrentNum)
                return 1;
            else
                return -1;
        }

        void CountGuesses(int _num)
        {
            if (lastGuess != _num)
                TotalGuesses++;
            lastGuess = _num;
        }

        internal int GetRandomNumber()
        {
            Random random = new();
            return random.Next(0, 9999);
        }
    }
}
