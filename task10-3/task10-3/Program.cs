using System;
using System.Collections.Generic;

namespace task10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число столбцов");
            int b = int.Parse(Console.ReadLine());

            int[,] FirstArray = new int[a, b];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.WriteLine($"Введите элемент {i} {j}");
                    FirstArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write($"{FirstArray[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            CheckOrder(FirstArray);

            static void CheckOrder(int[,] inputArray)
            {
                for (int j = 0; j < inputArray.GetLength(0); j++)
                {
                    List<int> myList = new List<int>();
                    for (int i = 1; i < inputArray.GetLength(1); i ++)
                    {
                        if (inputArray[j, i] > inputArray[j , i - 1])
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
                        for(int num = 0; num<myList.Count; num++)
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
