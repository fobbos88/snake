using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Point p = new Point(4, 5, '*');
            


            HorisontalLine upLine = new HorisontalLine(0, 78, 0, '+' );
            HorisontalLine downLine = new HorisontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();


            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();



            snake.Move();
            Thread.Sleep(300);
          






            Console.ReadLine();
        }
        
    }
}
