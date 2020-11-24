using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite x");
            Console.WriteLine("f(x) = " + (MathFunction(double.Parse(Console.ReadLine()))));
        }

        public static double MathFunction (double a)
        {
            if (a>2)
                return 2;
            if (a > 0 && a <= 2)
                return 0;
            else
                return -3 * a;
        }
    }
}
