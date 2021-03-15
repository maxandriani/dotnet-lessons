using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public static class OperatorPrecedence
    {
        public static void MultiplyPrecedenceOverSum(int a, int b, int c)
        {
            int result = a + b * c;
            Console.WriteLine($"The result of a + b * c is {result}");
        }

        public static void ControlPrecedenceFlowWithParentesis(int a, int b, int c)
        {
            int result = (a + b) * c;
            Console.WriteLine($"The result of (a + b) * c is {result}");
        }

        public static void ComplexPrecendenceFlow(int a, int b, int c)
        {
            int result = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine($"The result of (a + b) - 6 * c + (12 * 4) / 3 + 12 is {result}");
        }

        public static void IntegerDivisionResutnsIntegerOnly(int a, int b, int c)
        {
            int result = (a + b) / c;
            Console.WriteLine($"The result of an integer division (a + b) / c returns an integer result {result}");
        }
    }
}
