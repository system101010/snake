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
        // protected чсто бы переменная была видна у наследников

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Drow();
            }
        }
    }
}
