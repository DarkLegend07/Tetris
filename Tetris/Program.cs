using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            
            Point p1 = new Point();
            p1.x = 2;
            p1.y = 3;
            p1.c = '+';
            p1.Draw();

            //point p2 = new point();
            //p2.x = 3;
            //p2.y = 3;
            //p2.c = '+';
            //p2.draw();
            Point p2 = new Point()
            {
                x = 4,
                y = 5,
                c = '+'
            };

            p2.Draw();


            Console.ReadLine();
        }
        
    }
}
