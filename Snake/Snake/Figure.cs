using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> Line;

        public void Draw()
        {
            foreach (Point temp in Line)
            {
                temp.Draw();
            }
        }
    }
}
