using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] candidates = new string[2] { "Donald Trump", "Hillary Clinton" };

            Console.WriteLine("Your choices for the next president are: ");

            foreach (string candid in candidates)
            {
                Console.WriteLine(candid);
            }

            Console.WriteLine("Who do you think will win: ");

            string userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "hilary":
                case "hillary clinton":
                case "clinton":
                    Console.WriteLine("You chose the security freak");
                    break;
                case "donald":
                case "trump":
                case "donald trump":
                    Console.WriteLine("The world is about to have a war, nice knowing you");
                    break;
                default:
                    Console.WriteLine("Sorry the choice you have gone for got scared.");
                    break;
            }
        }
    }
}
