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

        public VerticalLine(int x, int ytop, int ybott, char s)
        {
            pList = new List<Point>();
            for (int i = ytop; i <= ybott; i++)
            {
                Point p = new Point(x, i, s);
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
