using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        public int x;//задаем начальные координаты
        public int y;
        public char sym;//задаем символ вывода

        public Point(int xn, int yn, char symn)//точки с данными координатами
        {
            x = xn;
            y = yn;
            sym = symn;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y); //выводим начало координат
            Console.Write(sym);//выводим символ
        }
    }
}
