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

            //добавить точки в список
            Point p3 = new Point(10, 13, '%');
            p1.Draw();

            Point p4 = new Point(20, 60, '?');
            p2.Draw();


            //классы
            List<int> numList = new List<int>();//переменная numList являетс переменной класса List, хранящих список целочисленных переменных
            numList.Add( 0 ); //список целочисленных перменных
            numList.Add( 1 );
            numList.Add( 2 );

            //для получения доступа к этим переменным надо знать порядковый номер
            int x = numList[ 0 ];
            int y = numList[ 1 ];
            int z = numList[ 2 ];

            //можно пройтись по всем значениям списка и вывести их на консоль, цикл foreach
            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            //для удаления какого либо элемента используется remove
            numList.RemoveAt(0);

            //можно создать список содержащих несколько точек
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            Console.ReadLine();//ожидает нажатие кнопки

        }
        //для того чтобы код вывода точки не повторять, заведем функцию для этого действия 

    }
}
