using System;
using System.Collections.Generic;

namespace ListsAndCollectionChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Expanda o que você compilou até o momento com números Fibonacci. Tente escrever o código para gerar os 20 primeiros números na sequência.");

            var fibo = new List<int>() { 1, 1 };

            while (fibo.Count < 20)
            {
                var last = fibo[fibo.Count - 1];
                var penultimate = fibo[fibo.Count - 2];

                fibo.Add(last + penultimate);
            }

            Console.WriteLine($"Sequência Fibonacci: {string.Join(", ", fibo)}");
            Console.ReadKey();
        }
    }
}
