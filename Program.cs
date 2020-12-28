using System;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число для генерации последнеий цифры по алгоритму");


            ulong n = new ulong();
            while (true)
            {
                var UserNumber = (Console.ReadLine());

                if (!ulong.TryParse(UserNumber, out n))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }
                else
                {
                    Console.WriteLine($"{UserNumber}{genNumber(UserNumber)}\nВведите число для проверки алгоритма\n");
                    Console.WriteLine(checkNumber(Console.ReadLine()));
                    break;
                }
            }
        }
        
        static int[,] FirstArray = new int[,]
        {
        {0, 1, 2, 3, 4, 5, 6, 7, 8, 9},
        {1, 2, 3, 4, 0, 6, 7, 8, 9, 5},
        {2, 3, 4, 0, 1, 7, 8, 9, 5, 6},
        {3, 4, 0, 1, 2, 8, 9, 5, 6, 7},
        {4, 0, 1, 2, 3, 9, 5, 6, 7, 8},
        {5, 9, 8, 7, 6, 0, 4, 3, 2, 1},
        {6, 5, 9, 8, 7, 1, 0, 4, 3, 2},
        {7, 6, 5, 9, 8, 2, 1, 0, 4, 3},
        {8, 7, 6, 5, 9, 3, 2, 1, 0, 4},
        {9, 8, 7, 6, 5, 4, 3, 2, 1, 0}
        };

        static int[,] SecondArray = new int[,]
        {
        {0, 1, 2, 3, 4, 5, 6, 7, 8, 9},
        {1, 5, 7, 6, 2, 8, 3, 0, 9, 4},
        {5, 8, 0, 3, 7, 9, 6, 1, 4, 2},
        {8, 9, 1, 6, 0, 4, 3, 5, 2, 7},
        {9, 4, 5, 3, 1, 2, 6, 8, 7, 0},
        {4, 2, 8, 6, 5, 7, 3, 9, 0, 1},
        {2, 7, 9, 3, 8, 0, 6, 4, 1, 5},
        {7, 0, 4, 6, 9, 1, 3, 2, 5, 8}
        };

        static int[] InverseTable = { 0, 4, 3, 2, 1, 5, 6, 7, 8, 9 };

        static int[] ConvertStringToReverseArray(string num)
        {
            int[] IntArray = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
            {
                IntArray[i] = int.Parse(num.Substring(i, 1));
            }

            Array.Reverse(IntArray);

            return IntArray;

        }
        static bool checkNumber(string num)
        {
            int tempNumber = 0;
            int[] IntArray = ConvertStringToReverseArray(num);

            for (int i = 0; i < IntArray.Length; i++)
            {
                tempNumber = FirstArray[tempNumber, SecondArray[(i % 8), IntArray[i]]];
            }

            return tempNumber == 0;

        }

        
        static string genNumber(string num)
        {
            int tempNumber = 0;
            int[] IntArray = ConvertStringToReverseArray(num);

            for (int i = 0; i < IntArray.Length; i++)
            {
                tempNumber = FirstArray[tempNumber, SecondArray[((i + 1) % 8), IntArray[i]]];
            }

            return InverseTable[tempNumber].ToString();
        }

        
        
        
    }
}
