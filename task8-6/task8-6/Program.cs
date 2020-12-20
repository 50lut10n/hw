using System;

namespace task8_6
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < b - a + 1; i++) //Для каждого числа нужно проверить - не является ли оно простым или квадратом простого
            {
                int checknumber = a + i; //checknumber - поочередно каждое число между а и б включительно
                if (Math.Sqrt(checknumber) == (double)(int)Math.Sqrt(checknumber)) //Проверка на то, что число checknumber квадрат целого числа
                {
                    if (IsNumberPrime((int)Math.Sqrt(checknumber))) //Проверка что корень checknumber не является простым числом
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write($"{checknumber} ");
                    }
                }
                else // Число checknumber не является квадратом, нужно проверить - не является ли оно простым
                {
                    if (IsNumberPrime(checknumber))
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write($"{checknumber} ");
                    }
                }
            }

    


            static bool IsNumberPrime(int i) //Проверка на то, что число является простым
            {
                for (int j=2;j<= (int)Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        return false;
                        break;
                    }
                }
                return true;
            }



        }
    }
}
