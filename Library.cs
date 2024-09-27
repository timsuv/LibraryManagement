using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibraryManagement
{
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; private set; }

        public Library(string name)
        {
            this.Name = name;
            this.Books = new List<Book>();
            ExistingBooks();
        }
        public void ExistingBooks()
        {
            Books.Add(new Book("Harry Potter", "JK Rowling", "9876789", 50));
            Books.Add(new Book("The Hobbit", "J.R.R. Tolkien", "1234567", 30));
            Books.Add(new Book("1984", "George Orwell", "2345678", 1));
        }
        public void AddBook(Book book)
        {
           
            //using linq to find if the ISBN is already in the system
            bool alreadyExist = Books.Any(b => b.ISBN == book.ISBN);
            if (alreadyExist)
            {
                Console.WriteLine("A book with the same ISBN already exists");

                Books.Add(book);
                Console.WriteLine(book.ToString());
            }
            else
            {
                Books.Add(book);
                Console.WriteLine(book.ToString());
            }
           

        }
        public void ShowAllBooks()
        {
            if (Books.Count == 0)
            {
                Console.WriteLine("The library is empty for now, you can add some books!");
            }
            else
            {
                int index = 1;
                foreach (var books in Books)
                {
                    Console.WriteLine($"{index}. {books.ToString()}");
                    index++;
                }
            }
        }
        public void LoanBook()
        {
            Console.WriteLine("Choose which book you want to loan by writing the number of the book ");
            ShowAllBooks();
            int choice = -1;
            bool isValid = false;
            while (!isValid)
            {
                if (int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice <= Books.Count)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please choose a number corresponding to a book");
                }
            }
            var selectedBook = Books[choice - 1];

            if (selectedBook.CopiesAvailable > 0)
            {

                selectedBook.CopiesAvailable--;
                if (selectedBook.CopiesAvailable == 0)
                {
                    Books.Remove(selectedBook);
                    Console.WriteLine($"The {selectedBook} is not longer available");
                }
                Console.WriteLine($"You loaned {selectedBook}");
            }
            else
            {
                Console.WriteLine("The book is not available to loan!");
            }
        }

    }
}
