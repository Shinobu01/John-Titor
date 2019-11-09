using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Point
    {
        int x, y;
        char sym;
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }

    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            VerticalLine l1 = new VerticalLine(2, 7, 1, '█');
            l1.Draw();
            VerticalLine l2 = new VerticalLine(1, 2, 2, '█');
            l2.Draw();
            VerticalLine l3 = new VerticalLine(2, 3, 3, '█');
            l3.Draw();
            VerticalLine l4 = new VerticalLine(3, 4, 4, '█');
            l4.Draw();
            VerticalLine l5 = new VerticalLine(4, 7, 5, '█');
            l5.Draw();
            VerticalLine l6 = new VerticalLine(6, 8, 6, '█');
            l6.Draw();
            VerticalLine l7 = new VerticalLine(8, 9, 7, '█');
            l7.Draw();
            VerticalLine l8 = new VerticalLine(8, 9, 14, '█');
            l8.Draw();
            VerticalLine l9 = new VerticalLine(6, 8, 15, '█');
            l9.Draw();
            VerticalLine l10 = new VerticalLine(4, 7, 16, '█');
            l10.Draw();
            VerticalLine l11 = new VerticalLine(3, 4, 17, '█');
            l11.Draw();
            VerticalLine l12 = new VerticalLine(2, 3, 18, '█');
            l12.Draw();
            VerticalLine l13 = new VerticalLine(1, 2, 19, '█');
            l13.Draw();
            VerticalLine l14 = new VerticalLine(2, 7, 20, '█');
            l14.Draw();
            VerticalLine l15 = new VerticalLine(8, 9, 2, '█');
            l15.Draw();
            VerticalLine l16 = new VerticalLine(9, 10, 3, '█');
            l16.Draw();
            VerticalLine l17 = new VerticalLine(8, 9, 19, '█');
            l17.Draw();
            VerticalLine l18 = new VerticalLine(9, 10, 18, '█');
            l18.Draw();
            VerticalLine l19 = new VerticalLine(11, 15, 4, '█');
            l19.Draw();
            VerticalLine l20 = new VerticalLine(12, 17, 3, '█');
            l20.Draw();
            VerticalLine l21 = new VerticalLine(13, 22, 2, '█');
            l21.Draw();
            VerticalLine l22 = new VerticalLine(15, 20, 1, '█');
            l22.Draw();
            VerticalLine l23 = new VerticalLine(22, 23, 3, '█');
            l23.Draw();
            VerticalLine l24 = new VerticalLine(23, 24, 4, '█');
            l24.Draw();
            VerticalLine l25 = new VerticalLine(11, 15, 17, '█');
            l25.Draw();
            VerticalLine l26 = new VerticalLine(12, 17, 18, '█');
            l26.Draw();
            VerticalLine l27 = new VerticalLine(13, 22, 19, '█');
            l27.Draw();
            VerticalLine l28 = new VerticalLine(15, 20, 20, '█');
            l28.Draw();
            VerticalLine l29 = new VerticalLine(22, 23, 18, '█');
            l29.Draw();
            VerticalLine l30 = new VerticalLine(23, 24, 17, '█');
            l30.Draw();
            VerticalLine l31 = new VerticalLine(13, 14, 5, '█');
            l31.Draw();
            VerticalLine l32 = new VerticalLine(14, 14, 16, '█');
            l32.Draw();
            VerticalLine l33 = new VerticalLine(16, 17, 7, '█');
            l33.Draw();
            VerticalLine l34 = new VerticalLine(17, 18, 8, '█');
            l34.Draw();
            VerticalLine l35 = new VerticalLine(16, 17, 13, '█');
            l35.Draw();
            VerticalLine l36 = new VerticalLine(17, 18, 14, '█');
            l36.Draw();
            HorizontalLine h1 = new HorizontalLine(8, 13, 9, '█');
            h1.Draw();
            HorizontalLine h2 = new HorizontalLine(8, 13, 10, '█');
            h2.Draw();
            HorizontalLine h3 = new HorizontalLine(8, 13, 11, '█');
            h3.Draw();
            HorizontalLine h4 = new HorizontalLine(8, 13, 12, '█');
            h4.Draw();
            HorizontalLine h5 = new HorizontalLine(4, 17, 24, '█');
            h5.Draw();
            HorizontalLine h6 = new HorizontalLine(5, 16, 25, '█');
            h6.Draw();
            HorizontalLine h7 = new HorizontalLine(7, 14, 26, '▀');
            h7.Draw();
            HorizontalLine h8 = new HorizontalLine(7, 8, 19, '▀');
            h8.Draw();
            HorizontalLine h9 = new HorizontalLine(13, 14, 19, '▀');
            h9.Draw();
            HorizontalLine h10 = new HorizontalLine(10, 10, 21, '▀');
            h10.Draw();
            HorizontalLine h11 = new HorizontalLine(11, 11, 20, '▄');
            h11.Draw();
            HorizontalLine h12 = new HorizontalLine(12, 12, 21, '▀');
            h12.Draw();
            Console.ReadKey();
        }
    }
}
