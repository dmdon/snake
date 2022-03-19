using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class VerticalLine
    {

        List<Point> pList;

        public VerticalLine(int yUp, int yDown, int x, char sym)//yUp - координата верхней точки по оси Y, yDown - координата нижней точки по оси Y, x - координата точки по оси X, sym - символ
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

    }
}
