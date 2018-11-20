﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
           //  Console.WriteLine("test");
           // конструктор вызывается при создании нового объекта

        }
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move (int offset, Direction direction)
        {
            if (direction == Direction.RIGHT) x = x + offset;
            if (direction == Direction.LEFT) x = x - offset;
            if (direction == Direction.UP) y = y - offset;
            if (direction == Direction.DOWN) y = y + offset;
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Drow ()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Drow();
        }
        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
