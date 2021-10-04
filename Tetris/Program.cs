using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Figure[] f = new Figure[2];
            f[0] = new Square(2, 5, '+');
            f[1] = new Stick(6, 6, '+');

            foreach (Figure fig in f)
            {
                fig.Draw();
            }

            //Square s = new Square(2, 5, '+');
            //s.Draw();

            //Stick stick = new Stick(6, 6, '+');
            //stick.Draw();

            //Point p1 = new Point(2, 3, '+');            
            //p1.Draw();

            //point p2 = new point();
            //p2.x = 3;
            //p2.y = 3;
            //p2.c = '+';
            //p2.draw();
            //Point p2 = new Point()
            //{
            //    x = 4,
            //    y = 5,
            //    c = '+'
            //};

            //p2.Draw();


            Console.ReadLine();
        }
        static void Drow(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
