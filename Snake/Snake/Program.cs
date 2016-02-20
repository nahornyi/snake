﻿using System;
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

            HorizontalLine hl = new HorizontalLine(1,78,0,'+');
            hl.DrawLine();
            HorizontalLine hl1 = new HorizontalLine(1, 78, 24, '+');
            hl1.DrawLine();
            VerticalLine vl = new VerticalLine(0,0,24,'+');
            vl.DrawLine();
            VerticalLine vl1 = new VerticalLine(78, 0, 24, '+');
            vl1.DrawLine();


            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.DrawLine();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

                Thread.Sleep(100);
                snake.Move();
            }

            Console.ReadKey();
        }

     

        

    }
}
