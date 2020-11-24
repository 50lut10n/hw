using System;

namespace ConsoleApp2
{

    class Program
    {
        static void Main()
        {
            var tros = "трос";
            string sort = tros.Substring(3, 1) + tros.Substring(2, 1) + tros.Substring(1, 1) + tros.Substring(0, 1);
            string rost = tros.Substring(1, 1) + tros.Substring(2, 1) + tros.Substring(3, 1) + tros.Substring(0, 1);
            Console.WriteLine($"Результат: {sort}, {rost}.");
            Console.ReadKey();
        }
    }
}