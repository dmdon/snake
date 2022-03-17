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

            //Используя констуктор Point, прописанный в файле Point.cs он берет конструкцию оттуда
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(2, 6, '#');
            p2.Draw();
            Console.ReadLine();//ожидает нажатие кнопки

        }
        //для того чтобы код вывода точки не повторять, завдем функцию для этого действия 

    }
}
