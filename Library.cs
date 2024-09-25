﻿using System;
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

        public void AddBook(string title, string author, string isbn, int copiesAvailable)
        {
            Book book = new Book();
            Books.Add(book);
        }
        public void ShowAllBooks()
        { 
        foreach (var books in Books)
            {
                Console.WriteLine(books.ToString());
            }
        }
        
      
    }
}
