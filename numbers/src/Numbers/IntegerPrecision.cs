using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public static class IntegerPrecision
    {
        public static void IntegerPrecisionMath(int a, int b, int c)
        {
            int result = (a + b) / c;
            int rest = (a + b) % c;

            Console.WriteLine($"The operation (a + b) / c results a Quotient of {result} and a remainer of {rest}");
        }

        public static void IntegerLimits()
        {
            int min = int.MinValue;
            int max = int.MaxValue;

            Console.WriteLine($"The limit of integer number is the interval of {min} and {max}");
        }

        public static void IntegerOverflow()
        {
            int max = int.MaxValue;
            max += 3;

            Console.WriteLine($"If a math operation produces a number bigger then integer max limit {int.MaxValue}, occurs an integer overflow {max}. The number becames closer the minimum limit + 2 {int.MinValue}");
        }
    }
}
