using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            var n = Program.delenie("n");
            
            Console.WriteLine(n);
        }

        public static bool delenie (string x)
        {
            Console.WriteLine("vvedite chislo " + x);
            var n = int.Parse(Console.ReadLine());
            return n % 5 == 0 && n % 7 != 0;
        }

    }
}


