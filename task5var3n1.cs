using System;
using System.Linq;
namespace task5var3n1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение на кириллице");
            Translator(Console.ReadLine().ToLower());
        }
        static void Translator(string InputString)
        {
            string RussianAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string CSsingleletters = "A6BrDEE13u0K0MHOnPCTY0x041100b000";
            string CSdoubleletters = "u*JIcpL|`bbI-)IO9I";
            string CStrippleletters = "}|{LLILLL";
            for (int i=0; i<InputString.Length; i++)
            {
                if (RussianAlphabet.IndexOf(InputString[i]) != -1)
                {
                    int TempIndex = RussianAlphabet.IndexOf(InputString[i]);
                    if (CSsingleletters[TempIndex] == '0')
                    {
                        string NewTempString = CSsingleletters.Substring(0, TempIndex + 1);
                        int whichzero = NewTempString.ToCharArray().Count(c => c == CSsingleletters[TempIndex]);
                        Console.Write(CSdoubleletters.Substring(whichzero * 2 - 2, 2));
                    }
                    else if (CSsingleletters[TempIndex] == '1')
                    {
                        string NewTempString = CSsingleletters.Substring(0, TempIndex + 1);
                        int whichone = NewTempString.ToCharArray().Count(c => c == CSsingleletters[TempIndex]);
                        Console.Write(CStrippleletters.Substring(whichone * 3 - 3, 3));
                    }
                    else
                    {
                        Console.Write(CSsingleletters[TempIndex]);
                    }
                }
                else
                {
                    Console.Write(InputString[i]);
                }
                }
            }
        }
    }
