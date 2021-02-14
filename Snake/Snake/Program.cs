using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(4, 3, '*');
            Point p2 = new Point(3, 2, '-');
            Point p3 = new Point(2, 1, '+');
            Point p4 = new Point(1, 0, '|');

            List<Point> AllPoints = new List<Point>(){
                p1, p2, p3, p4
            };

            /* The same as
            AllPoints.Add(p1);
            AllPoints.Add(p2);
            AllPoints.Add(p3);
            AllPoints.Add(p4);
            */

            foreach (Point i in AllPoints)
            {
                i.Draw();
            }

            Console.ReadLine();
        }
    }
}
