using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Figure
    {
       protected List<Point> pList;//общая часть из класса вертикальные линии //изменили модификатор доступа, чтобы переменная была видна у наследников

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

    }
}
