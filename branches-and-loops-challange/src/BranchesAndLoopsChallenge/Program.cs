using System;

namespace BranchesAndLoopsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um código C# para encontrar a soma de todos os inteiros de 1 a 20 divisíveis por 3... ");

            int sum = 0;

            for (int i = 0; i < 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"O resultado é {sum}");
            Console.ReadKey();
        }
    }
}
