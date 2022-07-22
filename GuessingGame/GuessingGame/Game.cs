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
        int currentGuess = -1;

        internal void RunGame()
        {
            Setup();

            Console.WriteLine("I've got a number from 0 to 9999, please make a guess.");
            string input;

            while (currentGuess != CurrentNum)
            {
                input = Console.ReadLine();
                while (!ValidateInput(input))
                {
                    Console.WriteLine("Please enter a whole number.");
                    input = Console.ReadLine();
                }

                int result = CheckGuess(currentGuess);
                if (result > 0)
                    Console.WriteLine("Your guess is too high, please pick another number.");
                else if (result < 0)
                    Console.WriteLine("Your guess is too low, please pick another number.");
            }

            Console.WriteLine($"Congratulations! You've won!\nYou made {TotalGuesses} guesses.\nDo you want to play again (Y/N)?");
            if (Console.ReadLine() == "Y")
                RunGame();
        }

        internal void Setup()
        {
            CurrentNum = GetRandomNumber();
            TotalGuesses = 0;
            lastGuess = int.MaxValue;
            currentGuess = int.MaxValue;
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
