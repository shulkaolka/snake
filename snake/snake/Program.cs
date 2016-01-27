using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
            {
                Verticalline vl = new Verticalline(0, 10, 5, '%');
                Draw(vl);

                Point p = new Point(4, 5, '*');
                Figure fSnake = new Snake(p, 4, Direction.RIGHT);
                Draw(fSnake);
                Snake snake = (Snake)fSnake;

                Horisontalline hl = new Horisontalline(0, 5, 6, '&');

                List<Figure> figures = new List<Figure>();
                figures.Add(fSnake);
                figures.Add(vl);
                figures.Add(hl);

                foreach (var f in figures)
                {
                    f.Draw();
                }
            Console.ReadLine();
            }

            static void Draw(Figure figure )
		{
                figure.Draw();
            }
        }
    }
