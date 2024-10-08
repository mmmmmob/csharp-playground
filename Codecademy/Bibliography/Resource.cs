using System;
using System.Data.Common;

namespace BiblioInheritance
{
  class Resource
  {
    // PROPERTIES
    public string Title { get; private set; }
    public string Category { get; private set; }
    public string Status { get; protected set; }
    public List<string> Holds { get; private set; }
    public Resource(string title, string category)
    {
      Title = title;
      Category = category;
      Status = "Available";
      Holds = [];
    }

    // METHODS
    // flag with 'virtual' allowing inherited class to override
    public virtual void UpdateStatus()
    {
      Status = Status == "Available" ? "Out" : "Available";
    }
    public virtual void GetInfo()
    {
      Console.WriteLine($"Title: {Title}\nCategory: {Category}\nStatus: {Status}");
    }
    public void Holding(string name)
    {
      if (Status == "Out")
      {
        Holds.Add(name);
      }
      else
      {
        Console.WriteLine("This item is available to borrow");
      }
    }
    public void HoldList()
    {
      Console.WriteLine("Waiting List:");
      if (Holds.Count == 0)
      {
        Console.WriteLine("No holds currently.");
      }
      else
      {
        foreach (string holder in Holds)
        {
          Console.WriteLine(holder);
        }
      }
    }
  }
}