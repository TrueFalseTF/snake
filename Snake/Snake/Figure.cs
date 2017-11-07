using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        public virtual void Drow()// virtual - ключевое слово делающее метод доступным для переопределения в наследниках
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
