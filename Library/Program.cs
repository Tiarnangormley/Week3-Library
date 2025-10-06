using Library;

class Program
{
    static void Main(string[] args)
    {
        Book myBook = new Book("C# for beginners", "Bill Gates", "1234567"); //Creates new instance of book

        //Output book information to the console
        myBook.DisplayInfo();
    }
}
