﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 0;
            p1.y = 0;
            p1.sym = '*';
            p1.Draw();
            Console.ReadLine();
        }
    }
}