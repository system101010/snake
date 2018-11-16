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
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

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

            HorisontalLine upline = new HorisontalLine(0, 78, 0, '+' );
            HorisontalLine downline = new HorisontalLine(0, 78, 24, '+');
            upline.Drow();
            downline.Drow();
            VerticalLine leftline = new VerticalLine(0, 24, 0, '-');
            VerticalLine rightline = new VerticalLine(0, 24, 78, '-');
            leftline.Drow();
            rightline.Drow();
            
            Console.ReadLine();
        }

        
    }
}
