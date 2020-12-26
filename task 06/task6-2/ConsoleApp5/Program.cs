using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {


            var n = Program.vvedenie("x");
            var m = Program.vvedenie("y");
            Console.WriteLine(Program.proverka(n, m));
        }

        public static bool proverka(double a, double b)
        {
            return (a >= 2 && b >= 0 || a >= 1 && b <= -1);
        }
        public static double vvedenie(string z)
        {
            Console.WriteLine("vvedite " + z);
            var n = double.Parse(Console.ReadLine());
            return (n);
        }

    }
}
