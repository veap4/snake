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

        //Функция вывода точки в консоль
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
