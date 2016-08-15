using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> booklist = new List<string>();

            booklist.Add("book 1");
            booklist.Add("book 2");
            booklist.Add("book 3");
            booklist.Add("book 4");
            booklist.Add("book 5");

            string response;

            Console.WriteLine("Please enter A, to add a book, D, to delete a book, S, to sort, L, to List, G to search and X to quit");
            response = Console.ReadLine();

            while (response != "X") 
            {
                Console.WriteLine("Please enter A, to add a book, D, to delete a book, S, to sort, L, to List, G to search and X to quit");
                response = Console.ReadLine();

                switch (response)
                {
                    case "A":
                        Console.WriteLine("Please Enter a Book to add");
                        string addBook = Console.ReadLine();
                        booklist.Add(addBook);
                        break;
                    case "D":
                        Console.WriteLine("Please Enter a Book to remove");
                        string removeBook = Console.ReadLine();
                        booklist.Remove(removeBook);
                        break;
                    case "S":
                        booklist.Sort();
                        foreach (string i in booklist)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case "L":
                        foreach (string i in booklist)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case "G":
                        Console.WriteLine("Please Enter a Book to search for");
                        string searchBook = Console.ReadLine();
                        Console.WriteLine(booklist.Contains(searchBook));
                        break;
                    case "X":
                        Console.WriteLine("GoodBye");
                        response = "X";
                        break;
                    default:
                        Console.WriteLine("Incorrect Input");
                        break;

                }


            } 
     


        }

        


       
    }
}
