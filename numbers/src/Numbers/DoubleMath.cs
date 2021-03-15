using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public static class DoubleMath
    {
        public static void SimpleDoubleMath(double a, double b, double c)
        {
            double result = (a + b) / c;
            Console.WriteLine($"The resolution of (a + b) / c using double is {result}");
        }

        public static void DoubleInterval()
        {
            Console.WriteLine($"O intervalo de um campo double consiste em um número entre {double.MinValue} e {double.MaxValue}");
        }

        public static void DoublePrecision()
        {
            Console.WriteLine($"As you may know, 0.3 is equivalent to 3/10. But that value is not the same as 1/3. The same way 0.33 is 33/100 and that number is very closer 1/3, but it is not the same.");
            Console.WriteLine($"0.3 -> {3.0 / 10.0}");
            Console.WriteLine($"0.33 -> {33.0 / 100.0}");
            Console.WriteLine($"1/3 ~~> {1.0 / 3.0}");
        }
    }
}
