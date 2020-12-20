using System;

namespace task8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите количество элементов в ряду");
            int amount = int.Parse(Console.ReadLine());


            Console.WriteLine("Введите элементы ряда через запятую");
            string initialstring = Console.ReadLine();

            string[] allnumbers = initialstring.Split(',');

            int resultat = 1;
            for (int i = 0; i < amount; i++)
            {
                resultat *= int.Parse(allnumbers[i]);
            }
            Console.WriteLine($"\nРезульат: {resultat}");
        }
    }
}
