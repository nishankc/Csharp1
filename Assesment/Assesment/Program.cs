using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assesment
{
    class Program
    {

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        //static void Main(string[] args)
        //{
        //    List<Book> books = new List<Book>();
        //    string input = "";

        //    // create 4 new books to add into the program, makes testing it easier
        //    Book book1 = new Book("Book1", "Author1", "isbn1", 10);
        //    Book book2 = new Book("Book2", "Author2", "isbn2", 11);
        //    Book book3 = new Book("Book3", "Author3", "isbn3", 12);
        //    Book book4 = new Book("Book4", "Author4", "isbn4", 13);

        //    // adding the books to the list
        //    books.Add(book1);
        //    books.Add(book2);
        //    books.Add(book3);
        //    books.Add(book4);


        //    //do while to start up the menu and its options, followed by switch statement so user can choose the option.
        //    do
        //    {
        //        Console.WriteLine("Please choose an option:");
        //        Console.WriteLine("1) Add a Book");
        //        Console.WriteLine("2) List all books");
        //        Console.WriteLine("3) Delete a book");
        //        Console.WriteLine("4) Search a book");
        //        Console.WriteLine("0) Quit");
        //        input = Console.ReadLine();

        //        switch (input)
        //        {
        //            case "1":
        //                Console.Clear();
        //                Console.WriteLine("Please Enter the name of the book:");
        //                string title = Console.ReadLine();
        //                Console.WriteLine("Please enter the authors name:");
        //                string author = Console.ReadLine();
        //                Console.WriteLine("Please enter the ISBN Number");
        //                string isbn = Console.ReadLine();
        //                Console.WriteLine("Please enter the price");
        //                double price = double.Parse(Console.ReadLine());
        //                books.Add(new Book(title, author, isbn, price));
        //                break;
        //            case "2":
        //                Console.WriteLine(Book.ListAllBooks(books));
        //                break;
        //            case "3":
        //                Console.WriteLine("Enter a book name to delete: ");
        //                string titleSearched = Console.ReadLine();
        //                Book.DeleteBook(books, titleSearched);
        //                break;
        //            case "4":
        //                Console.WriteLine("Enter a book name to Search: ");
        //                titleSearched = Console.ReadLine();
        //                Console.WriteLine(Book.SearchBook(books, titleSearched));
        //                break;
        //            case "0":
        //                Console.WriteLine("Goodbye");
        //                break;
        //            default:
        //                Console.WriteLine("Incorrect Input");
        //                break;




        //        }

        //    } while (input != "0");



        //}
    }
}
