using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        string Title;
        string Author;
        string ISBN;

        void DisplayInfo()
        {
            Console.WriteLine($"Book title; {Title}");
            Console.WriteLine($"Book Author; {Author}");
            Console.WriteLine($"Book ISBN; {ISBN}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Book myBook = new Book(); //Creates new instance of book
            myBook.Title = "C# for beginngers";
            myBook.Author = "Bill Gates";
            myBook.ISBN = "1234";

            // ADD ANOTHER BOOK
            //C# Mehthods
            // Microsoft
            // 3456778

            Book myBook2 = new Book();
            myBook2.Title = "C# Methods";
            myBook2.Author = "Microsoft";
            myBook2.ISBN = "3456778";

            //Output book information to the console
            myBook.DisplayInfo();
            myBook2.DisplayInfo();
        }

    }
}
