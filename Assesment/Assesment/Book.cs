using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    class Book
    {
        // attributes for a book
        public string title;
        public string author;
        public string isbn;
        public double price;


        //constructor so you can create a book
        public Book(string title, string author, string isbn, double price)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.price = price;
        }


        //to list all the books
        public static string ListAllBooks(List<Book> books)
        {
            string output = "";

            //foreach to go through the list
            foreach(var book in books)
            {
                //Console.WriteLine("-----------------");
                //Console.WriteLine("Book Title: {0}\nAuthor: {1}\nISBN Number: {2}\nPrice: £{3:F2}",book.title, book.author, book.isbn, book.price);
                output += "\n------------------------\nTitle: " + book.title + "\nAuthor: " + book.author + "\nISBN: " + book.isbn + "\nPrice: £" + book.price.ToString("F");

            }

            return output;
        }

        public static void DeleteBook(List<Book> books, string titleSearched)
        {
            //lambda expression to check if the book title matches the title input, ignores case
            Book result = books.Find(x => x.title.Equals(titleSearched, StringComparison.CurrentCultureIgnoreCase));
            //Deletes the book from the list
            books.Remove(result);

        }

        public string Display()
        {
            return "Book Title: " + title + "Book Author: " + author + "ISBN: " + isbn + "Price: £" + price;
        }


        //searches for books then displays the result
        public static string SearchBook(List<Book> books, string titleSearched)
        {
            string output = "";

            Book result = books.Find(x => x.title.Equals(titleSearched,StringComparison.CurrentCultureIgnoreCase));

            //output the searched book
            output = "\n------------------------\nTitle: " + result.title + "\nAuthor: " + result.author + "\nISBN: " + result.isbn + "\nPrice: £" + result.price.ToString("F") + "\n------------------------";
            return output;
        }
    }
}
