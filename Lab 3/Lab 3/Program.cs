using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Point
    {

        int x;
        int y;
        char sym;

        public void SetX(int x)
        {
            if (x >= 0)
                this.x = x;
            else
                throw new Exception("Значение x не может быть отрицательным");
        }
        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                throw new Exception("Значение y не может быть отрицательным");
        }
        public void SetSym(char symbol)
        {
            sym = symbol;
        }
        public void Draw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Point p = new Point();
                int i;
                int[] crdn_x = new int[5];
                int[] crdn_y = new int[5];
                char[] psym = new char[5];
                
                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine("Введите кооринаты x{0}:", i + 1);
                    crdn_x[i] = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                
                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine("Введите кооринаты y{0}:", i + 1);
                    crdn_y[i] = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                
                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine("Введите {0} символ:", i + 1);
                    psym[i] = char.Parse(Console.ReadLine());
                }
                Console.Clear();
                for (i = 0; i < 5; i++)
                {
                    p.SetX(crdn_x[i]);
                    p.SetY(crdn_y[i]);
                    p.SetSym(psym[i]);
                    p.Draw(crdn_x[i], crdn_y[i]);
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
