using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int x1, int x2, int y, char symb)
        {
            Line = new List<Point>();
            for(int x = x1; x <= x2; x++)
            {
                Point temp = new Point(x, y, symb);
                Line.Add(temp);
            }
        }
    }
}
