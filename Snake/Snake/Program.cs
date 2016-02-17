﻿using System;
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
            int y1 = 3;
            char symbol1 = '*';
            DrawSymbol( x1, y1, symbol1 );
           

            int x2 = 4;
            int y2 = 5;
            char symbol2 = '#';
            DrawSymbol( x2, y2, symbol2 );
           

            Console.ReadKey();
        }

        static void DrawSymbol(int x, int y, char symbol)
        {
            Console.SetCursorPosition( x, y );
            Console.Write( symbol );
        }

    }
}
