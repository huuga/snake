using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');

            List<int> numList = new List<int>();
            numList.Add(21);
            numList.Add(11);
            numList.Add(90);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            List<Point> pointsList = new List<Point>();
            pointsList.Add(p1);
            pointsList.Add(p2);

            int r = pointsList[1].x;

            HorizontalLine Line1 = new HorizontalLine();
            Line1.Draw();

            VerticalLine line2 = new VerticalLine(8, 24, 9, '$');
            line2.Draw();

            Console.ReadLine();
        }


    }
}