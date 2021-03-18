using System;

namespace IndexAndRangeApp
{
  class Program
  {
    static string[] words = new string[]
    {
                  // index from start    index from end
      "The",      // 0                   ^9
      "quick",    // 1                   ^8
      "brown",    // 2                   ^7
      "fox",      // 3                   ^6
      "jumped",   // 4                   ^5
      "over",     // 5                   ^4
      "the",      // 6                   ^3
      "lazy",     // 7                   ^2
      "dog"       // 8                   ^1
    };            // 9 (or words.Length) ^0

    static void Main(string[] args)
    {
      Console.WriteLine("Indexes");
      Console.WriteLine("=====================================");
      Console.WriteLine();

      Console.WriteLine($"The last word is {words[^1]}");

      Console.WriteLine("Ranges");
      Console.WriteLine("=====================================");
      Console.WriteLine();

      string[] quickBrownFox = words[1..4];
      Console.WriteLine(string.Join(" ", quickBrownFox));

      string[] lazyDog = words[^2..^0];
      Console.WriteLine(string.Join(" ", lazyDog));

      string[] allWords = words[..]; // contains "The" through "dog".
      string[] firstPhrase = words[..4]; // contains "The" through "fox"
      string[] lastPhrase = words[6..]; // contains "the, "lazy" and "dog"
      Console.WriteLine(string.Join(", ", allWords));
      Console.WriteLine(string.Join(" ", firstPhrase));
      Console.WriteLine(string.Join(" ", lastPhrase));
    }
  }
}
