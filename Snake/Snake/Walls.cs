using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls (int mapWidht, int mapHeight)
        {
            wallList = new List<Figure>();
            HorisontalLine upLine = new HorisontalLine(0, mapWidht - 2, 0, '+');
            HorisontalLine downLine = new HorisontalLine(0, mapWidht - 2, mapHeight - 1, '+');
            VerticalLine lefLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidht - 2, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(lefLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure)) return true;
            }
            return false;
        }

        public void Drow()
        {
            foreach (var wall in wallList) wall.Drow();
        }
    }
}
