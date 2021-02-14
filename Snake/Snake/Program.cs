using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 4;
            p1.y = 2;
            p1.symb = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 3;
            p2.y = 1;
            p2.symb = '-';
            p2.Draw();


            Console.ReadLine();
        }
    }
}
