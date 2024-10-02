using System;
using System.Data.Common;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Initially setup password specifications
      int minLength = 9;
      string specialChars = "!@#$%^&*";

      Console.Write("Enter your password: ");
      string userInput = Console.ReadLine()!;

      bool hasUppercase = false;
      bool hasLowercase = false;
      bool hasDigit = false;
      bool hasSpecialChar = false;

      // Check each character in the user input
      foreach (char c in userInput)
      {
        // We can omit the { } if inside if statement only contains ONE statement to be executed
        if (char.IsUpper(c)) hasUppercase = true;
        else if (char.IsLower(c)) hasLowercase = true;
        else if (char.IsDigit(c)) hasDigit = true;
        else if (specialChars.Contains(c)) hasSpecialChar = true;
      }

      // Calculate the score using shorthand expressions
      int score = 0;
      if (userInput == "1234")
      {
        score = 0;
      }
      else
      {
        score += userInput.Length >= minLength ? 1 : 0;
        score += hasUppercase ? 1 : 0;
        score += hasLowercase ? 1 : 0;
        score += hasDigit ? 1 : 0;
        score += hasSpecialChar ? 1 : 0;
      }

      // Output the result
      Console.WriteLine($"Your password score is {score}.");

      switch (score)
      {
        case 1:
          Console.WriteLine("It's a WEAK password.");
          break;
        case 2:
          Console.WriteLine("It's a MEDIUM STRONG password.");
          break;
        case 3:
          Console.WriteLine("It's a STRONG password.");
          break;
        case >= 4:
          Console.WriteLine("It's an EXTREMELY STRONG password.");
          break;
        default:
          Console.WriteLine("It doesn't met out standard.");
          break;
      }
    }
  }
}
