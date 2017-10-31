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
            int x = 1;
            Func1(x);
            Console.WriteLine("Call Func1. x = " + x);//создаётся стек X для int и стек value для параметра Func1(x)

            x = 1;
            Func2(x);
            Console.WriteLine("Call Func2. x = " + x);//создаётся стек value для параметра Func2(x)

            x = 1;
            Func3(x);
            Console.WriteLine("Call Func3. x = " + x);//создаётся стеу x для параметра Func3(x)

            Point p1 = new Point(1, 3, '*');
            Move(p1, 10, 10);
            Console.WriteLine("Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y);//создаётся стек адреса p1 инкапсулированного объекта с конструктором Point (создаётся куча значений x, y, sym данного объекта); создаётся 3 стека p, dx, dy для параметров Move(p1,10,10)

            Point p2 = new Point(4, 5, '#');
            p1 = p2;
            p2.x = 8;
            p2.y = 8;
            Console.WriteLine("p1 = p2. p1.x = " + p1.x + ", p1.y = " + p1.y + "; p2.x = " + p2.x + ", p2.y = " + p2.y);//создаётся стек адреса p2 инкапсулированного с помощью конструктора объекта Point (создаётся куча значений x, y, sym данного объекта); адрес стека p1 объявляется равным адресу стека p2; куча значений объекта p2 принимает значения x и y, а т.к. адреса p2 и p1 равны то объекту p1 принадлежат значения этой же кучи (его собственная куча была удалена)

            p1 = new Point(2, 7, '*');
            Update(p1);
            Console.WriteLine("Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y);//куча обекта с адресным стеком p1 принимает значения x, y, sym; создаётся стек p для параметра функции Update(p1);

            Console.ReadLine();
        }

        public static void Func1(int value)//создаётся стек value
        {

        }

        public static void Func2(int value)//создаётся стек value с которым производятся операции
        {
            value = value + 1;
        }

        public static void Func3(int x)//создаётся стек x с которым производятся операции
        {
            x = x + 1;
        }

        public static void Move(Point p, int dx, int dy)//создаётся стек p, dx, dy; стек p принимает аргумент со значением адреса объекта; производятся операции с кучей значений объекта адрес которого был принят.
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }

        public static void Update(Point p)//создаётся стек p; стек p принимает аргумент со значением адреса объекта; стек p становится стеком адреса инкапсулированного с помощью конструктора объекта Point(6, 8, '+');
        {
            p = new Point(6,8,'+');
        }
        //Как не сложно заметить, если присвоить стеку адреса объекта значение стека адреса другого обекта, то оба стека будут ссылаться на кучу последнего. Однако новая инкапсуляция объекта, с присвоением адреса в любой адресный стек делает этому обекту новую кучу значений. 

    }
}