using System;

namespace task10var3nB
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
            SumByColumn(FirstArray);
        }
        
        static void SumByColumn(int[,] inputArray)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                int addition = 0;
                for (int i = 0; i < inputArray.GetLength(0); i += 2)
                {
                    addition += inputArray[i, j];
                }
                Console.WriteLine($"В столбце с индексом {j} сумма элементов на нечетных позициях равняется {addition}");
            }
        }
    }
}
