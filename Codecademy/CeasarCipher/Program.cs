using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

      Console.Write("Your secret message: ");
      string secretString = Console.ReadLine()!;

      // Convert input to lowercase and make char array
      char[] secretMessage = secretString.ToLower().ToCharArray();
      char[] encryptedMessage = new char[secretString.Length];

      for (int i = 0; i < secretMessage.Length; i++)
      {
        // If char is space or symbol, continue next loop
        if (Array.IndexOf(alphabet, secretMessage[i]) == -1)
        {
          continue;
        }
        char secretChar = secretMessage[i];
        int secretCharPosition = Array.IndexOf(alphabet, secretChar);
        // Use modulo to not exceed 26 characters
        int newLetterPosition = (secretCharPosition += 3) % alphabet.Length;
        encryptedMessage[i] = alphabet[newLetterPosition];
      }

      Console.WriteLine($"Your encrypted message is: {String.Join("", encryptedMessage)}");
    }
  }
}