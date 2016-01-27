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
            Console.SetBufferSize(80, 25);
            ConsoleKeyInfo rkey;
            Walls walls = new Walls(80, 25);
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            walls.Draw();
            snake.Draw();
            food.Draw();


            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.Clear();
                    Console.SetCursorPosition(36, 10);
                    Console.WriteLine("GAME OVER");
                    Console.SetCursorPosition(16, 11);
                    Console.WriteLine("Press 'y' if you want to start a new game");
                    Console.SetCursorPosition(18, 12);
                    Console.WriteLine("Or press any key for exit from game...");
                    rkey = Console.ReadKey();
                    if  (rkey.KeyChar != 'y')
                    {
                        break;
                    }
                    Console.Clear();
                    snake = new Snake(p, 4, Direction.RIGHT);
                    walls.Draw();
                    snake.Draw();
                    food.Draw();
                }
                if (snake.Eat(food))
                {
                    //food ;
                    /*while (snake.IsHitFood(food = foodCreator.CreateFood()))
                    {
                        food = foodCreator.CreateFood();
                    }*/
                    while (true)
                    {
                        food = foodCreator.CreateFood();
                        if (!(snake.IsHitFood(food)))
                        {
                            break;
                        }
                    }
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandlKey(key.Key);
                }
            }
        }
 
    }
}
