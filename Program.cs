using System;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число b");
            int b = int.Parse(Console.ReadLine());
            int[] FirstArray = new int[15];

            for (int i = 0; i < 15; i++) //Заполнение массива числами
            {
                int PowerOfTwo = 1;
                for (int j=0; j<i; j++) //Вычисление значений чисел для массива
                {
                    PowerOfTwo *= 2;
                }
                FirstArray[i] = PowerOfTwo - b;
            }
            Console.WriteLine("\nПервоначальный массив");
            ArrayPrinter(FirstArray);



            //Начало всех методов, использованных в программе
            static void ArrayPrinter(int[] InputArray) //Метод для печати массива через точку с запятой
            {
                for (int i = 0; i < InputArray.Length; i++)
                {
                    Console.Write($"{InputArray[i]}; ");
                }
                Console.WriteLine();
            }

            static void ModifyArray(int[] InputArray) //Метод для модификации массива
            {
                for (int i = 0; i < InputArray.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        InputArray[i] *= -1;
                    }
                }
            }

            static double CalculateAverageFromArray(int[] InputArray)
            {
                double SummOfNumbers = 0;
                for (int i = 0; i<15; i++)
                {
                    SummOfNumbers += (double)InputArray[i];
                }
                SummOfNumbers /= 15;
                return Math.Round(SummOfNumbers, 3);
            }

            static int[] GetRemainder(int[] InputArray, int kValue)
            {
                int[] NewArray = new int[15];

                for (int i=0; i<15; i++)
                {
                    NewArray[i] = InputArray[i] % kValue;
                }

                return NewArray;

            }
            //Конец всех методов, используемых в программе


            Console.WriteLine("\nМодифицированный массив:");
            ModifyArray(FirstArray);
            ArrayPrinter(FirstArray);

            Console.WriteLine($"\nСреднее арифметическое массива: {CalculateAverageFromArray(FirstArray)}");

            Console.WriteLine("\nВведите значение для делителя k (натуральное число)");
            int Divider = int.Parse(Console.ReadLine());

            Console.WriteLine("\nМассив с остатками от деления на k:");
            ArrayPrinter(GetRemainder(FirstArray, Divider));
        }
    }
}
