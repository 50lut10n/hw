using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MathFunction("x"));
        }

        
        public static double MathFunction(string a)
        {
            Console.WriteLine("vvedite chislo " + a);
            double n = double.Parse(Console.ReadLine());
            return Math.Sqrt((2 * n + Math.Sin(Math.Abs(3 * n))) / 3.56);
        }
    }
}
