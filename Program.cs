using System.Xml.Linq;

namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Library library = new Library("My library");
            library.AddBook("Harry Potter", "JK Rowling", "1", 50);
            library.ShowAllBooks();

        }
    }
}
