using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        readonly Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {
            pList = new List<Point>();
            direction = _direction; 
            for(int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, _direction);
                pList.Add( p );
            }
        }

        public void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();

        }
        private Point GetNextPoint()
        {
            Point nextPoint = new Point(pList.Last());
            nextPoint.Move(1, direction);
            
            return nextPoint;
        }

    }
}
