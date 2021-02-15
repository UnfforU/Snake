using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symb;

        public Point()
        {
        }
        
        public Point(int _x, int _y, char _symb)
        {
            x = _x;
            y = _y;
            symb = _symb;
        }
        
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symb = p.symb;
        }

        public void Move(int shift, Direction direction)
        {
            if (direction == Direction.DOWN)
            {
                y+=shift;
            } else 
            if (direction == Direction.LEFT)
            {
                x-=shift;
            } else
            if(direction == Direction.RIGHT)
            {
                x+=shift;
            } else
            if(direction == Direction.UP)
            {
                y-=shift;
            }
        }

        public void Clear()
        {
            symb = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
    }
}
