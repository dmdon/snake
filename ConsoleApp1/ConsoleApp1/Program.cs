using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //берем одну точку и символ
            int x1 = 1;//задаем начальные координаты
            int y1 = 3;
            char sym1 = '*';//задаем символ вывода
            Draw(x1, y1, sym1);

            //берем вторую точку и символ
            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            Draw(x2, y2, sym2);
            Console.ReadLine();//ожидает нажатие кнопки

        }
        //для того чтобы код вывода точки не повторять, завдем функцию для этого действия 
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y); //выводим начало координат
            Console.Write(sym);//выводим символ
        }
    }
}
