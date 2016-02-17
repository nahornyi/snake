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

            Point p3 = new Point(8, 10, '|');
            p3.DrawSymbol();

            Point p4 = new Point(14, 17, '/');
            p4.DrawSymbol();


            List<char> symbolList = new List<char>();

            symbolList.Add('*');
            symbolList.Add('#');
            symbolList.Add('|');

            foreach (char i in symbolList)
            {
                Console.WriteLine( i );
            }

            List<Point> pList = new List<Point>();

            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
                

            Console.ReadKey();
        }

     

        

    }
}
