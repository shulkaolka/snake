using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Horisontalline line = new Horisontalline(5, 10, 8, '+');
            Verticalline line2 = new Verticalline(5, 10, 4, '=');
            Console.SetBufferSize(80, 25);
            Horisontalline line = new Horisontalline(0, 78, 0, '+');
            Verticalline line2 = new Verticalline(0, 24, 0, '=');
            Horisontalline line3 = new Horisontalline(0, 78, 24, '+');
            Verticalline line4 = new Verticalline(0, 24, 78, '=');
            line.Draw();
            line2.Draw();
            line3.Draw();
            line4.Draw();*/
            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            Console.ReadLine();

        }
    }
}
