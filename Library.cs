using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public void AddBook(Book book)
        {
            
            bool alreadyExist = Books.Any(b => b.ISBN == book.ISBN);
            if (alreadyExist)
            {
                Console.WriteLine("A book with the same ISBN already exists");
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
                foreach (var books in Books)
                {
                    Console.WriteLine(books.ToString());
                }
            }


        }


    }
}
