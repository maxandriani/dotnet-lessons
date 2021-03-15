using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public static class IntegerMath
    {
        public static int Sun(int a, int b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static int Division(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Não dividirás por zero!");
            }
            return a / b;
        }

    }
}
