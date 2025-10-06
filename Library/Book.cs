using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
     class Book
    {    //Variables
        private string title;
        private string author;
        private string isbn;

        //Title property allows access to the private variable
        public string Title
        {
            get { return title; } //Get Method
            set { title = value; } //Setter
        }

        public string Author
        {
            get { return author; } //Getter
            set { author = value; } //Setter
        }

        public string Isbn
        {
            get { return isbn; } //Getter
            set {  isbn = value; } //Setter
        }

        //Example of a constructor that allows us to construst a new Book Object
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.title = bookTitle;
            this.author = bookAuthor;
            this.isbn = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title; {title}");
            Console.WriteLine($"Book Author; {author}");
            Console.WriteLine($"Book ISBN; {isbn}");
            Console.WriteLine();
        }

    }
}
