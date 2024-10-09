using System;

namespace SavingInterface
{
  class PasswordManager : IDisplayable, IResetable
  {
    public string Password
    { get; set; }

    public bool Hidden
    { get; private set; }

    public string HeaderSymbol { get; }

    public PasswordManager(string password, bool hidden)
    {
      while (password.Length < 8)
      {
        Console.WriteLine("Password needs to be at least 8 characters. Please try again:");
        password = Console.ReadLine()!;
      }

      Password = password;
      Hidden = hidden;
      HeaderSymbol = "Password\n---------";
    }

    public void Display()
    {
      Console.WriteLine(HeaderSymbol);
      if (Hidden)
      {
        Console.WriteLine("****");
      }
      else
      {
        Console.WriteLine(Password);
      }
    }

    public bool ChangePassword(string existingPW, string newPW)
    {
      if (existingPW == Password)
      {
        Password = newPW;
        Console.WriteLine("Password changed.");
        return true;
      }
      else
      {
        Console.WriteLine("Password didn't match.");
        return false;
      }
    }

    public void Reset()
    {
      Password = "";
      Hidden = false;
    }
  }
}