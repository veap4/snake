using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Размер экрана
            const int screenWidth = 100;
            const int screenHeight = 30;

            //Настраиваем консоль
            Console.SetWindowSize(screenWidth, screenHeight);
            Console.SetBufferSize(screenWidth, screenHeight);

            //Отрисовка рамочки
            HorizontalLine topLine = new HorizontalLine(0, screenWidth-2, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, screenWidth-2, screenHeight-1, '+');
            VerticalLine leftLine = new VerticalLine(0, screenHeight-1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, screenHeight-1, screenWidth-2, '+');
            topLine.Draw();
            bottomLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            //Инициализация змейки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            //
            FoodCreator foodCreator = new FoodCreator(screenWidth, screenHeight, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                    snake.Move();

                Thread.Sleep(100);

                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.SetDirection(key.Key);
                }
            }

        }
    }
}