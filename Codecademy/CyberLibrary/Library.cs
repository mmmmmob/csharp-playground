using System;
using System.Collections.Generic;

class Library
{
  public List<Book> books = new List<Book>();
  public void AddBook(Book book)
  {
    books.Add(book);
  }
  public List<Book> SearchBookByTitle(string title)
  {
    List<Book> serchResult = new List<Book>();
    foreach (Book book in books)
    {
      if (book.Title.Contains(title))
      {
        serchResult.Add(book);
      }
    }
    return serchResult;
  }
}