﻿using System;
using System.Collections.Generic;
using System.Windows;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            

            //Отрисовка рамки
            HorizontalLine TopLine = new HorizontalLine(0, 78, 0, '+');
            VerticalLine LeftLine = new VerticalLine(0, 0, 24, '+');
            HorizontalLine BottomLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine RightLine = new VerticalLine(78, 0, 24, '+');

            TopLine.Draw();
            LeftLine.Draw();
            BottomLine.Draw();
            RightLine.Draw();


            Point p = new Point(2, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            Console.ReadLine();
        }
    }
}
