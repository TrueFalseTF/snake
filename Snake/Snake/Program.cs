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
            Point p1 = new Point( 1, 3, '*');
            p1.Draw();

            Point p2 = new Point( 4, 5, '#');
            p2.Draw();

            Point p3 = new Point(6, 8, '&');
            p3.Draw();

            Point p4 = new Point(11, 4, '^');
            p4.Draw();

            List<char> numList = new List<char>(); // Встроенный класс "Список"< тип объектов списка >
            numList.Add('#');// значение списка
            numList.Add('+');
            numList.Add('$');
            numList.Add('%');

            char a = numList[0];// присвоение значений списка переменным
            char b = numList[1];
            char c = numList[2];
            char d = numList[3];

            numList.RemoveAt(2);

            foreach (char i in numList)// цикл, позволяющий в каждой своей итерации присваивать переменной значение списка
            {
                Console.WriteLine(i);
            }

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            Point P1 = pList[0];
            Point P2 = pList[1];
            Point P3 = pList[2];
            Point P4 = pList[3];

            foreach (Point i in pList )
            {
                i.Draw();
            }
          




            Console.ReadLine();
        }

        
    }
}
