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
                        
            HorisontalLine upline = new HorisontalLine(0, 78, 0, '+' );
            HorisontalLine downline = new HorisontalLine(0, 78, 24, '+');
            upline.Drow();
            downline.Drow();
            VerticalLine leftline = new VerticalLine(0, 24, 0, '-');
            VerticalLine rightline = new VerticalLine(0, 24, 78, '-');
            leftline.Drow();
            rightline.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            Console.ReadLine();
        }

        
    }
}
