using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinners
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };

            foreach(string dwaves in sevenDwarves)
            {
                Console.WriteLine("{0}, your dinner is ready",dwaves);
            }

            for(var i = 0; i < sevenDwarves.Length; i++)
            {
                string dwarf = sevenDwarves[i];
                Console.WriteLine("{0}, your drink is ready", dwarf);
            }
        }
    }
}
