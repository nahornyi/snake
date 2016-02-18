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
            Point p1 = new Point( 1, 3, '*' );
            p1.DrawSymbol();

            Point p2 = new Point( 4, 5, '#');
            p2.DrawSymbol();

            HorizontalLine hl = new HorizontalLine(5,10,8,'+'); ;
            hl.DrawLine();

            VerticalLine vl = new VerticalLine(12,5,10,'*');
            vl.DrawLine();


            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.DrawLine();

            Console.ReadKey();
        }

     

        

    }
}
