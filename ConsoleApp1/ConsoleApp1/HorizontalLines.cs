using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    class HorizontalLine : Figure //класс горизонтальных линий //наследование от класса фигура
    {

        private int у;

        //конструктор для рисования любых произвольных линий
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            //внутри конструктора заполняем правильным образом список pList
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point( x, у, sym );//добавляем точки с нужными координатами
                pList.Add(p);//добавляем список точек
            }
        }

    }
}
