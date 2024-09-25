using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Menu
    {
        Library library = new Library("My library");
        

        public void ShowMenu()
        {
            Console.WriteLine("Welcome to the library, what do you want to do?");
            bool exit = false;

            while (!exit)
            {
                
                
                Console.WriteLine("[1] Return a book");
                Console.WriteLine("[2] Show the books in the library");
                Console.WriteLine("[3] Loan a book");
                Console.WriteLine("[4] Finish the program");
             
                //Console.Clear();
                int choice;

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Book newBook = new Book();
                            library.AddBook(new Book("Harry Potter", "JK Rowling", "1", 50));

                            library.AddBook(newBook);
                            break;
                        case 2:
                          
                            library.ShowAllBooks();
                            break;
                        case 3:
                            library.LoanBook();
                           
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice, choice between the ranges");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input, choose between 1 and 3");
                }
            }

        }
    }
}
