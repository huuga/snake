using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}
