using System;

namespace task8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вещественное число а>1");
            double a = double.Parse(Console.ReadLine());

            double summa = 0;
            int initialint = 2;
            while (summa <= a)
            {
                summa += (1 / Math.Sqrt(initialint));
                initialint += 1;
            }
            Console.WriteLine($"\nn minimal= {initialint}");
        }
    }
}
