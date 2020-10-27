using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку на кириллице ЗАГЛАВНЫМИ буквами");
            string original = Console.ReadLine();
            int length = original.Length;
            for (int i = 0; i < length; i = i + 1)
            {
                string temp = (original[i]).ToString();
                Console.Write(Function(temp));
                if (i == length-1)
                    Console.WriteLine("");
            }
        }
        public static string Function(string letter)
        {

            if (letter == "А")
                return ("A");
            else if (letter == "Б")
                return ("6");
            else if (letter == "В")
                return ("B");
            else if (letter == "Г")
                return ("r");
            else if (letter == "Д")
                return ("D");
            else if (letter == "Е" ^ letter == "Ё")
                return ("E");
            else if (letter == "Ж")
                return ("}|{");
            else if (letter == "З")
                return ("3");
            else if (letter == "И")
                return ("u");
            else if (letter == "Й")
                return ("u*");
            else if (letter == "К")
                return ("K");
            else if (letter == "Л")
                return ("JI");
            else if (letter == "М")
                return ("M");
            else if (letter == "Н")
                return ("H");
            else if (letter == "О")
                return ("O");
            else if (letter == "П")
                return ("n");
            else if (letter == "Р")
                return ("P");
            else if (letter == "С")
                return ("C");
            else if (letter == "Т")
                return ("T");
            else if (letter == "У")
                return ("Y");
            else if (letter == "Ф")
                return ("cp");
            else if (letter == "Х")
                return ("X");
            else if (letter == "Ц")
                return ("L|");
            else if (letter == "Ч")
                return ("4");
            else if (letter == "Ш")
                return ("LLI");
            else if (letter == "Щ")
                return ("LLL");
            else if (letter == "Ъ")
                return ("`b");
            else if (letter == "Ы")
                return ("bI");
            else if (letter == "Ь")
                return ("b");
            else if (letter == "Э")
                return ("-)");
            else if (letter == "Ю")
                return ("IO");
            else if (letter == "Я")
                return ("9I");
            else
                return (letter);

        }
    }




}