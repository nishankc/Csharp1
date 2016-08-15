using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //create arrays for the numbers
            int[] userNumbers = new int[5];
            int sum = 0;
            decimal average = 0;

            //ask for the first number
            Console.WriteLine("Please Enter your five numbers(seperated by a space)");

            string userNumber = Console.ReadLine();

            string[] numbers = userNumber.Split(' ');

            for(int i = 0; i < numbers.Length; i++)
            {
                userNumbers[i] = Convert.ToInt32(numbers[i].ToString());
            }

            foreach(int output in userNumbers)
            {
                Console.WriteLine(output);
            }

            for( int i = 0; i < userNumbers.Length; i++)
            {
                sum += userNumbers[i];
            }

            average = sum / userNumbers.Length;

            Console.WriteLine("Your Average is {0}", average);





        }
    }
}
