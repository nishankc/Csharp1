using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assesment
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();
        

        // create 4 new books to add into the program, makes testing it easier
        Book book1 = new Book("Book1", "Author1", "isbn1", 10);
        Book book2 = new Book("Book2", "Author2", "isbn2", 11);
        Book book3 = new Book("Book3", "Author3", "isbn3", 12);
        Book book4 = new Book("Book4", "Author4", "isbn4", 13);

        


        public Form1()
        {
            InitializeComponent();
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            labelAuthorName.Hide();
            labelBookTitle.Hide();
            labelISBN.Hide();
            labelPrice.Hide();
            textBoxTitle.Hide();
            textBoxAuthor.Hide();
            textBoxISBN.Hide();
            textBoxPrice.Hide();
            button3.Hide();
            labelShowAllBooks.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // adding the books to the list
            
            labelShowAllBooks.Text = Book.ListAllBooks(books);
            labelShowAllBooks.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Show();
            labelAuthorName.Show();
            labelBookTitle.Show();
            labelISBN.Show();
            labelPrice.Show();
            textBoxTitle.Show();
            textBoxAuthor.Show();
            textBoxISBN.Show();
            textBoxPrice.Show();
            labelShowAllBooks.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string author = textBoxAuthor.Text;
            string isbn = textBoxISBN.Text;
            string stringprice = textBoxPrice.Text;
            double price = double.Parse(stringprice);
            books.Add(new Book(title, author, isbn, price));
            labelAuthorName.Hide();
            labelBookTitle.Hide();
            labelISBN.Hide();
            labelPrice.Hide();
            textBoxTitle.Hide();
            textBoxAuthor.Hide();
            textBoxISBN.Hide();
            textBoxPrice.Hide();
            button3.Hide();
            button1.Show();
            button2.Show();
        }
    }
}
