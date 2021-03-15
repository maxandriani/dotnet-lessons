using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Math!");

            IntegerMathFlow();
            OperatorPrecedenceFlow();
            IntegerPrecisionFlow();
            DoubleMathFlow();
        }

        static void IntegerMathFlow()
        {
            Console.WriteLine("Give me two operands (positive integer numbers): ");

            int a = int.Parse(Console.ReadLine()),
                b = int.Parse(Console.ReadLine());

            Console.WriteLine($"The Sun of {a} and {b} is {IntegerMath.Sun(a, b)}.");
            Console.WriteLine($"The Diference between {a} and {b} is {IntegerMath.Subtraction(a, b)}.");
            Console.WriteLine($"The Multiplication of {a} and {b} is {IntegerMath.Multiplication(a, b)}.");
            Console.WriteLine($"The Division of {a} by {b} is {IntegerMath.Division(a, b)}.");
            Console.ReadKey();
        }

        static void OperatorPrecedenceFlow()
        {
            Console.WriteLine($"Give me tree operands (positive integer only): ");
            int a = int.Parse(Console.ReadLine()),
                b = int.Parse(Console.ReadLine()),
                c = int.Parse(Console.ReadLine());

            OperatorPrecedence.MultiplyPrecedenceOverSum(a, b, c);
            OperatorPrecedence.ControlPrecedenceFlowWithParentesis(a, b, c);
            OperatorPrecedence.ComplexPrecendenceFlow(a, b, c);
            OperatorPrecedence.IntegerDivisionResutnsIntegerOnly(a, b, c);
            Console.ReadKey();
        }

        static void IntegerPrecisionFlow()
        {
            Console.WriteLine("Give me three operands (positive integer only): ");
            int a = int.Parse(Console.ReadLine()),
                b = int.Parse(Console.ReadLine()),
                c = int.Parse(Console.ReadLine());

            IntegerPrecision.IntegerPrecisionMath(a, b, c);
            IntegerPrecision.IntegerLimits();
            IntegerPrecision.IntegerOverflow();
            Console.ReadKey();
        }

        static void DoubleMathFlow()
        {
            Console.WriteLine("Give me three operands (positive real only): ");
            double a = double.Parse(Console.ReadLine()),
                   b = double.Parse(Console.ReadLine()),
                   c = double.Parse(Console.ReadLine());

            DoubleMath.SimpleDoubleMath(a, b, c);
            DoubleMath.DoubleInterval(); 
            DoubleMath.DoublePrecision();
            Console.ReadKey();
        }
    }
}
