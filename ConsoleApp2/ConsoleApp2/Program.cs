using System;

namespace ConsoleApp2
{
    
    class Program
    {
        static void Main()
        {
            Console.WriteLine(mathfunction(mathfunction(mathfunction(mathfunction(5, 4), 3), 2), 0));
        }

        public static double mathfunction (double i, double y)
        {

            return (Math.Sqrt(i)+y);
        }
    }
}
