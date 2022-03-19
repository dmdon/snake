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

        public Point(int _x, int _y, char _sym)//точки с данными координатами
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y); //выводим начало координат
            Console.Write(sym);//выводим символ
        }
    }
}
