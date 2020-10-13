using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());
            Console.Write(number%100);
            Console.WriteLine(number / 100);
            Console.ReadKey();

        }
    }
}




