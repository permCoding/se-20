using System;
using System.Collections.Generic;

namespace step1
{
    class Program
    {
        static void Main()
        {
            int countPoint = 10;

            List<Point> points = new List<Point>();
            points.Add(new Point());
            points.Add(new Point(5, 5));
            points.Add(new Point(0, 0));

            foreach (var point in points)
                Console.WriteLine($"X = {point.X}; Y = {point.Y}");

            Console.ReadLine();
        }
    }
}
