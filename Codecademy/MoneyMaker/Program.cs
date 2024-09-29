using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      // User input
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Enter the amount to convert to coins:");
      double userInput = Convert.ToDouble(Console.ReadLine());

      // Program logic
      double goldCoins = Math.Floor(userInput / 10);
      double remainder = userInput % 10;
      double silverCoins = Math.Floor(remainder / 5);
      remainder %= 5;

      // Display result
      Console.WriteLine($"{userInput} cents is equal to...");
      Console.WriteLine($"Gold coin(s): {goldCoins}");
      Console.WriteLine($"Silver coin(s): {silverCoins}");
      Console.WriteLine($"Bronze coin(s): {remainder}");
    }
  }
}
