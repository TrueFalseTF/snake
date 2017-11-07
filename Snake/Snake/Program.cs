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
            VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            Draw(v1);//созданн метод принимающий объект класса Figure как аргумент

            Point p = new Point(3,4, '*');
            Figure fSnake = new Snake(p, 4, Direktion.TOP);// инкапсулирован объект класса Figure
            Draw(fSnake);
            Snake snake = (Snake)fSnake;// Явное применение типов

            HorizontalLine h1 = new HorizontalLine(0, 30, 5, '%');

            List<Figure> figure = new List<Figure>();
            figure.Add(v1);
            figure.Add(snake);
            figure.Add(h1);

            foreach (var f in figure)
            {
                f.Drow();
            }

        }
        
        static void Draw( Figure figure)
        {
            figure.Drow();
        }
    }
}
