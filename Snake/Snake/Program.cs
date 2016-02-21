using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Console.SetBufferSize(80,25);

            VerticalLine vl = new VerticalLine(5,0,10,'%');
            Draw(vl);

            Point p = new Point(4,5,'*');
            Figure fsnake = new Snake(p,5,Direction.RIGHT);
            Draw(fsnake);
            Snake snake = (Snake)fsnake;

            HorizontalLine hl = new HorizontalLine(0,6,5,'&');
            List<Figure> figures = new List<Figure>();
            figures.Add(fsnake);
            figures.Add(vl);
            figures.Add(hl);
            foreach (var f in figures)
            {
                f.DrawLine();
            }

           
            Console.ReadKey();
        }

        static void Draw(Figure figure)
        {
            figure.DrawLine();
        }

     

        

    }
}
