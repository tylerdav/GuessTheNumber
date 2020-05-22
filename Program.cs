using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int secretNumber = rand.Next(1, 11);

            int guessesGiven = 0;

            while (guessesGiven < 4)
            {
                Console.WriteLine($"Try and guess the number between 1 and 10! Number of guesses ({guessesGiven + 1}) ");
                Console.WriteLine("");
                string userGuess = Console.ReadLine();
                Console.WriteLine();
                int userGuessInt = Int32.Parse(userGuess);

                if (userGuessInt == secretNumber)
                {
                    Console.WriteLine("Correct!");
                    break;
                }
                else if (userGuessInt > secretNumber)
                {
                    Console.WriteLine("Wrong, Too high!");
                    Console.WriteLine("-----------------------------------------------------------------");
                }
                else if (userGuessInt < secretNumber)
                {
                    Console.WriteLine("Wrong, Too Low!");
                    Console.WriteLine("-----------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("WRONG!");
                    Console.WriteLine("-----------------------------------------------------------------");
                }

                guessesGiven++;
            }
        }
    }
}