using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine TopLine = new HorizontalLine(5, 10, 10, '*');

            VerticalLine LeftLine = new VerticalLine(5, 10, 15, '*');

            HorizontalLine BottomLine = new HorizontalLine(5, 10, 15, '*');

            VerticalLine RightLine = new VerticalLine(10, 10, 15, '*');

            TopLine.Draw();
            LeftLine.Draw();
            BottomLine.Draw();
            RightLine.Draw();


            Console.ReadLine();
        }
    }
}
