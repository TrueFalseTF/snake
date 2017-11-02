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
            Console.SetBufferSize(80, 25);
            
            //Отрисовка рамочки            

            HorizontalLine hlineTop = new HorizontalLine(0, 78, 0, '|');
            HorizontalLine hLineBottom = new HorizontalLine(0, 78, 24, '|');
            VerticalLine vLineLeft = new VerticalLine(0, 24, 0, '|');
            VerticalLine vlineRight = new VerticalLine(0, 24, 78, '|');
               
            hlineTop.Drow();
            hLineBottom.Drow();
            vLineLeft.Drow();
            vlineRight.Drow();


            Point p = new Point(1, 3, '*');
            Snake snake = new Snake(p, 3, Direktion.RIGHT);
            snake.Drow();



            Console.ReadLine();
        }

        
    }
}
