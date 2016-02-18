using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pVerticalList;
        public VerticalLine(int x, int yTop, int yBottom, char sym)
        { 
            pVerticalList = new List<Point>();
            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x,y,sym);
                pVerticalList.Add(p);
            }
                
        }
        public void DrawLine()
        {
            foreach (Point p in pVerticalList)
            {
                p.DrawSymbol();
            }
        }

    }
}
