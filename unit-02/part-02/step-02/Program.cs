using System;
using System.Collections.Generic;

namespace step1
{
    class Program
    {
        static void Main()
        {
            int countPoint = 10;

            Point p = new Point();

            List<Point> points = new List<Point>();
            points.Add(p);
            points.Add(p);
            p.X = 15; // объект p ссылочного типа
            points.Add(p);

            foreach (var point in points)
                Console.WriteLine($"X = {point.X}; Y = {point.Y}");

            Console.ReadLine();
        }
    }
}
