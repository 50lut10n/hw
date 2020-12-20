using System;

namespace task8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            int myInt = int.Parse(Console.ReadLine());
            

            int MaxInt = 1;
            int mySize = (int)Math.Floor(Math.Log10(myInt) + 1);

            int IntNumber = 0;
            for (int i = mySize-1; i >= 0; i--)
            {
                int tempo = (int)(myInt / (Math.Pow(10, i))%10);
                if (tempo > MaxInt)
                {
                    MaxInt = tempo;
                    IntNumber = mySize-i;
                }
            }
            Console.WriteLine($"\nМаксимальное значение: {MaxInt} На позиции: {IntNumber} (от 1 до {mySize})");
        }
    }
}
