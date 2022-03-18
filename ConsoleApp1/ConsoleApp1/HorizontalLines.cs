using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HorizontalLines //класс горизонтальных линий
    {
        List<Point> pList;
        /*   Контсруктор для рисования 3 точек
             public HorizontalLines()
           {
               pList = new List<Point>();
               Point p1 = new Point(4, 4, '*');//добавим несколько точек из линии
               Point p2 = new Point(5, 4, '*');
               Point p3 = new Point(6, 4, '*');
               pList.Add(p1);//добавим несколько точек в список pList
               pList.Add(p2);
               pList.Add(p3);
               */
            int у = 8;
            //конструктор для рисования любых произвольных линий
        public HorizontalLines(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            //внутри конструктора заполняем правильным образом список pList
            for(int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point( x, у, sym );//добавляем точки с нужными координатами
                pList.Add(p);//добавляем список точек
            }
        }
        //метод вывода на экран
        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }

    }
}
