using System;
using System.Collections.Generic;

namespace task10var3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк");

            int n = new int();
            int m = new int();

            while (true)
            {
                var FirstInt = (Console.ReadLine());

                if (!int.TryParse(FirstInt, out n) || (int.Parse(FirstInt) < 5 || (int.Parse(FirstInt) > 20)))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }
                else
                {
                    n = int.Parse(FirstInt);
                    Console.WriteLine("Введите количество столбцов");

                    while (true)
                    {
                        var SecondInt = (Console.ReadLine());

                        if (!int.TryParse(SecondInt, out m) || (int.Parse(SecondInt) < 5 || (int.Parse(SecondInt) > 20)))
                        {
                            Console.WriteLine("Ошибка ввода\n");
                            continue;
                        }
                        else
                        {
                            n = int.Parse(FirstInt);
                            m = int.Parse(SecondInt);

                            break;
                        }
                    }
                    break;
                }
            }
            int[,] FirstArray = new int[n, m];
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    FirstArray[i, j] = r.Next(0, 99);
                    Console.Write(string.Format("{0,2} ", FirstArray[i, j]));
                }
                Console.WriteLine("");
            }
            CheckOrder(FirstArray);

            static void CheckOrder(int[,] inputArray)
        {
            for (int j = 0; j < inputArray.GetLength(0); j++)
            {
                List<int> myList = new List<int>();
                for (int i = 1; i < inputArray.GetLength(1); i++)
                {
                    if (inputArray[j, i] > inputArray[j, i - 1])
                    {
                        continue;
                    }
                    else
                    {
                        myList.Add(i);
                    }
                }
                if (myList.Count > 0)
                {
                    Console.Write($"В строке {j} неверный порядок имеют числа с индексами ");
                    for (int num = 0; num < myList.Count; num++)
                    {
                        Console.Write($"{myList[num]} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"В строке {j} все элементы имеют верный порядок");
                }
            }
        }
        }
    }
}
        