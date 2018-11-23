﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
       protected List<Point> pList;
        // protected что бы переменная была видна у наследников

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Drow();
            }
        }

        internal bool IsHit (Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p)) return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point)) return true;
            }
            return false;
        }
    }
}
