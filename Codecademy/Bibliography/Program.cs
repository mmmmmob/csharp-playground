using System;

namespace BiblioInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Book b = new Book("Code: The Hidden Language of Computer Hardware and Software", "Non-Fiction", ["Charles Petzold"], 396);
      b.GetInfo();
      b.UpdateStatus();
      b.Holding("John Doe");
      b.HoldList();

      Periodical p = new Periodical("Wired", "Technology", "Monthly");
      p.UpdateStatus();
      Console.WriteLine(p.Status);

      Video v = new Video("Ex Machina", "Sci-Fi", "Alex Garland", 108, "On-Demand");
      v.GetInfo();

    }
  }
}