using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Book
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int CopiesAvailable { get; set; }

        public Book(string title, string author, string ISBN, int copiesAvailable)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = ISBN;
            this.CopiesAvailable = copiesAvailable;
        }
        public Book()
        {
            Title = GetTitle();
            Author = GetAuthor();
            ISBN = GetISBN();
            CopiesAvailable = GetCopiesAvailable();
        }
        public void ShowBook()
        {
            Console.WriteLine($"You can loan {Title} by {Author}, the ISBN is {ISBN} and there is {CopiesAvailable} copies");
        }
        public bool AvailableBook()
        {
            if (CopiesAvailable > 0)
            {
                Console.WriteLine($"The book is available in {CopiesAvailable} copies");
                return true;
            }
            else
            {
                Console.WriteLine("There is no copies availbales");
                return false;
            }
        }
        public string GetTitle()
        {
            Console.WriteLine("Write the name of the book");
            return Console.ReadLine();
        }
        public string GetAuthor()
        {
            Console.WriteLine("Write the name of the author");
            return Console.ReadLine();
        }
        public string GetISBN()
        {
            Console.WriteLine("Write the ISBN");
            return Console.ReadLine();
        }
        public int GetCopiesAvailable()
        {
            Console.WriteLine("Write how many copies do you want to return");
            return Convert.ToInt32( Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Title: {Title} Author: {Author} ISBN: {ISBN} Copies Available: {CopiesAvailable} ";
        }

    }
}
