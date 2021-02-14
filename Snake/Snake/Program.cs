using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 4, y1 = 2;
            char symb1 = '*';

            Draw(x1, y1, symb1);

            int x2 = 3, y2 = 1;
            char symb2 = '-';

            Draw(x2, y2, symb2);


            Console.ReadLine();
        }

        static void Draw(int x,int y, char symb)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
    }
}
