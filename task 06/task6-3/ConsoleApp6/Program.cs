using System;

namespace Chess
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите позицию белой ладьи");
            var posWhite = Console.ReadLine().ToLower();

            Console.WriteLine("Введите позицию черного коня");
            var posBlack = Console.ReadLine().ToLower();

            Console.WriteLine("Введите ход белой ладьи");
            var moveWhite = Console.ReadLine().ToLower();

            Console.WriteLine("Возможность хода: {0}",
                IsRookCanMove(posWhite, moveWhite) &&
                !IsKnightCanMove(posBlack, moveWhite));



            Console.ReadKey();
        }

        static void DecodePosition(string position,
            out int column, out int row)
        {
            column = (int)position[0] - 0x60;
            row = (int)position[1] - 0x30;
        }

        static bool IsRookCanMove(string start, string end)
        {
            int startColumn, startRow, endColumn, endRow;

            DecodePosition(start, out startColumn, out startRow);
            DecodePosition(end, out endColumn, out endRow);

            return (startColumn == endColumn || startRow == endRow) && start != end;
        }

        static bool IsKnightCanMove(string start, string end)
        {
            int startColumn, startRow, endColumn, endRow;

            DecodePosition(start, out startColumn, out startRow);
            DecodePosition(end, out endColumn, out endRow);

            return Math.Abs(startRow - endRow) == 2 && Math.Abs(startColumn - endColumn)==1 ||
                Math.Abs(startRow - endRow) == 1 && Math.Abs(startColumn - endColumn) == 2;
        }

    }
}