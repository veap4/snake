using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        //Конструктор по умолчанию
        public Point()
        {
        }

        //Конструктор с инициализацией точки
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        //Конструктор с инициализацией из другой точки
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        //Функция смещения точки
        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.RIGHT:
                    x += offset;
                    break;
                case Direction.LEFT:
                    x -= offset;
                    break;
                case Direction.UP:
                    y -= offset;
                    break;
                case Direction.DOWN:
                    y += offset;
                    break;
            }
        }

        //Функция вывода точки в консоль
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
