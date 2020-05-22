using System;
using System.Collections.Generic;

namespace step1
{
    class Program
    {
        static void Main()
        {
            int countPoints = 10;
            byte width = 50, height = 25;
            Random rnd = new Random();

            List<Point> points = new List<Point>();
            while(points.Count < countPoints)
                points.Add(new Point(rnd.Next(1, width-1), rnd.Next(1, height - 1)));
            points.RemoveAt(3); points.RemoveAt(1);

            foreach (var point in points)
                Console.WriteLine($"id = {point.id}; X = {point.X}; Y = {point.Y}");

            Console.ReadLine();
        }
    }
}
