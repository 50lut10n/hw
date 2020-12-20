using System;

namespace task8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое ненулевое число");
            int b = int.Parse(Console.ReadLine());
            int i = -b+1;
            int summa = 0;
            while (i < b * b)
            {
                summa += i * i;
                i += 1;
            }
            Console.WriteLine(summa);
        }
    }
}
