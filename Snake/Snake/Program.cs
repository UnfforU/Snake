using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(4, 2, '*');
            p1.Draw();

            Point p2 = new Point(3, 1, '-');
            p2.Draw();


            Console.ReadLine();
        }
    }
}
