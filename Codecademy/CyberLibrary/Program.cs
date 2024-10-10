using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
  class Program
  {
    static void Main()
    {
      // Initialize library
      Library library = new Library();

      // Add some sample books
      Book b1 = new Book("1984", "George Orwell");
      Book b2 = new Book("To Kill a Mockingbird", "Harper Lee");

      library.AddBook(b1);
      library.AddBook(b2);

      // Search for a book
      List<Book> result = library.SearchBookByTitle("1984");

      // Display all books
      // search result
      Console.WriteLine("Search result:");
      foreach (Book book in result)
      {
        Console.WriteLine($"{book.Title} by {book.Author}");
      }
      Console.WriteLine();
      // all books in library
      Console.WriteLine("In library:");
      foreach (Book book in library.books)
      {
        Console.WriteLine($"{book.Title} by {book.Author}");
      }
    }
  }
}