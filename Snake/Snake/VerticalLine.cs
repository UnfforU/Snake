using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int y1, int y2, char symb)
        {
            pList = new List<Point>();
            for (int y = y1; y <= y2; y++)
            {
                Point temp = new Point(x, y, symb);
                pList.Add(temp);
            }
        }
    }
}
