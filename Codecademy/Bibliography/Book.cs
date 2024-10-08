using System;
using System.Reflection.Metadata;

namespace BiblioInheritance
{
  class Book : Resource
  {
    // PROPERTIES
    public string[] Author { get; private set; }
    public int PageCount { get; private set; }

    // CONSTRUCTOR
    public Book(string tile, string category, string[] author, int pageCount) : base(tile, category)
    {
      Author = author;
      PageCount = pageCount;
    }

    // METHOD (OVERRIDDEN)
    public override void GetInfo()
    {
      string allAuthors = "";
      foreach (string author in Author)
      {
        allAuthors += (allAuthors == "") ? author : $", {author}";
      }
      Console.WriteLine($"Title: {Title}\nCategory: {Category}\nAuthor: {allAuthors}\nPage Count: {PageCount}\nStatus: {Status}");
    }
  }
}