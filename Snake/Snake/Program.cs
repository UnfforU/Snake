using System;
using System.Collections.Generic;
using System.Threading;
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


            //Рисуем и двигаем змейку
            Point tile = new Point(2, 5, '*');
            Snake snake = new Snake(tile, 4, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                if(Console.KeyAvailable)
                    snake.NewDirection(Console.ReadKey().Key);
                
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
