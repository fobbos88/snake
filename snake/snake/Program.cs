﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorisontalLine line = new HorisontalLine(5, 10, 8, '+' );

            VerticalLine Line_V = new VerticalLine(5, 15, 1, '%');

            line.Draw();
            Line_V.Draw();
            
         
            Console.ReadLine();
        }
        
    }
}
