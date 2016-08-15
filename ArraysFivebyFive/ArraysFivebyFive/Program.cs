using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysFivebyFive
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] numbers = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };
            
            int rowLength = numbers.GetLength(0);
            int columnLenth = numbers.GetLength(1);
            int arraySum = 0;



            for (int row = 0; row < rowLength; row++)
            {
                int rowTotal = 0;

                for (int col = 0; col < columnLenth; col++)
                {
                    rowTotal += numbers[row, col];
                }

                Console.WriteLine("Row total is {0}", rowTotal);
            }

            for (int col = 0; col < columnLenth; col++)
            {
                int colTotal = 0;

                for (int row = 0; row < rowLength; row++)
                {
                    colTotal += numbers[row, col];
                }

                Console.WriteLine("Column total is {0}", colTotal);
            }

            for (int row = 0; row < rowLength; row++)
            {
                

                for (int col = 0; col < columnLenth; col++)
                {
                    arraySum += numbers[row, col];
                }

                
            }

            Console.WriteLine("Array sum is {0}", arraySum);


        }
    }
}
