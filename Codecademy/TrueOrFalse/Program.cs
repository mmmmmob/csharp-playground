using System;

namespace TrueOrFalse
{
  class Program
  {
    static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine()!;

      // Type your code below
      string[] questions = { "1+1 = 2?", "2^3 = 6?" };
      bool[] answers = { true, false };
      bool[] responses = new bool[2];

      if (questions.Length != answers.Length)
      {
        Console.WriteLine("System Malfunction!");
      }

      int askingIndex = 0;

      foreach (string question in questions)
      {
        string input;
        bool isBool;
        bool inputBool = false;

        Console.WriteLine(question);
        Console.WriteLine("true or false?");
        input = Console.ReadLine()!.ToLower();

        isBool = (input == "true" || input == "false") ? true : false;

        if (isBool == true)
        {
          inputBool = (isBool == true) ? true : false;
        }

        while (isBool == false)
        {
          Console.WriteLine("Use only true or false you idiot!");
          input = Console.ReadLine()!.ToLower();
          isBool = (input == "true" || input == "false") ? true : false;

          if (isBool)
          {
            inputBool = true;
          }
        }
        responses[askingIndex] = inputBool;
        askingIndex++;
      }

      int scoringIndex = 0;
      int score = 0;

      foreach (bool answer in answers)
      {
        bool userAnswer = responses[scoringIndex];
        Console.WriteLine($"{scoringIndex + 1}. Input: {string.Join(" ", answer)} | Answer: {string.Join(" ", userAnswer)}");

        if (userAnswer == answer)
        {
          score++;
        }
        scoringIndex++;
      }

      Console.WriteLine($"You got {score} out of {answers.Length} correct!");
    }
  }
}
