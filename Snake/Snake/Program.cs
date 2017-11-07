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

            //Отрисовка точек
            Point p = new Point(1, 3, '*');
            Snake snake = new Snake(p, 4, Direktion.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HendleKey(key.Key);
                }               
            }            
        }        
    }
}
