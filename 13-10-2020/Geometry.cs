using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Объем куба: " + a * a * a);
            Console.WriteLine("Диагональ куба: " + Math.Sqrt(3) * a);
            Console.ReadKey();
        }
    }
}
