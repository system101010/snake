using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 2;
            char sym1 = '*';
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 2;
            p1.sym = '*';
            p1.Drow();

            Point p2 = new Point(5, 5, '#');
            p2.Drow();

            HorisontalLine line = new HorisontalLine(5, 10, 8, '+' );
            line.Drow();
            WerticalLine line1 = new WerticalLine(5, 0, 8, '-');
            line1.Drow();
            
            Console.ReadLine();
        }

        
    }
}
