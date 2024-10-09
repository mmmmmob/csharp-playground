using System;

namespace SavingInterface
{
  class TodoList : IDisplayable, IResetable
  {
    public string[] Todos
    { get; private set; }

    private int nextOpenIndex;

    public string HeaderSymbol { get; }

    public TodoList()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
      HeaderSymbol = "Todo\n---------";
    }

    public void Add(string todo)
    {
      if (nextOpenIndex < 5)
      {
        Todos[nextOpenIndex] = todo;
        nextOpenIndex++;
      }
    }

    public void Display()
    {
      Console.WriteLine(HeaderSymbol);
      foreach (string todo in Todos)
      {
        if (String.IsNullOrEmpty(todo))
        {
          Console.WriteLine([]);
        }
        else
        {
          Console.WriteLine($"- {todo}");
        }
      }
    }

    public void Reset()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }
  }
}