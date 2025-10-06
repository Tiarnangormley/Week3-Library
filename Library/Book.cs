using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
     class Book
    {
        string Title;
        string Author;
        string ISBN;

        //Example of a constructor that allows us to construst a new Book Object
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title; {Title}");
            Console.WriteLine($"Book Author; {Author}");
            Console.WriteLine($"Book ISBN; {ISBN}");
            Console.WriteLine();
        }

    }
}
