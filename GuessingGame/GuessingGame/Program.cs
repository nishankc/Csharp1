using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Random number = new Random();
            int numberToGuess = number.Next(0,100);
            int count = 0;
            int userGuess = 0;

            


            do
            {
                Console.WriteLine("Please enter a number(between 1-100): ");
                userGuess = Int32.Parse(Console.ReadLine());

                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Your Guess is too low");
                    count++;
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Your Guess is too high");
                    count++;
                }
            } while (userGuess != numberToGuess);

                Console.WriteLine("Your number {0} was the correct guess. The number of guesses taken was {1}", userGuess, count);

            }
    }
}
