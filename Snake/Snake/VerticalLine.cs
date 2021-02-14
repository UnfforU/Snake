using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        
        List<Point> Line;

        public VerticalLine(int x, int y1, int y2, char symb)
        {
            Line = new List<Point>();
            for (int y = y1; y <= y2; y++)
            {
                Point temp = new Point(x, y, symb);
                Line.Add(temp);
            }
        }

        public void Draw()
        {
            foreach (Point temp in Line)
            {
                temp.Draw();
            }
        }
    }
}
