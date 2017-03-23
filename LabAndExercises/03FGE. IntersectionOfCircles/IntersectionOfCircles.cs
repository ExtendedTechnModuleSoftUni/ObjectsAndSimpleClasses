namespace _03FGE.IntersectionOfCircles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntersectionOfCircles
    {
        class Point
        {
            public int X { get; set; }

            public int Y { get; set; }
        }

        class Circle
        {
            public Point Center { get; set; }

            public int Radius { get; set; }

            static double CalcDistance(Point center1, Point center2)
            {
                int deltaX = center2.X - center1.X;
                int deltaY = center2.Y - center1.Y;

                return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            }

            public static bool Intersect(Circle c1, Circle c2)
            {
                double distance = Circle.CalcDistance(c1.Center, c2.Center);

                return distance <= (c1.Radius + c2.Radius);
            }
        }

        public static void Main()
        {
            var circles = new List<Circle>();

            for (int i = 0; i < 2; i++)
            {
                var inputLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var currentPoint = ReadPoint(inputLine);
                var currentCirle = new Circle { Center = currentPoint, Radius = inputLine[2] };

                circles.Add(currentCirle);
            }

            var firstCirle = circles[0];
            var secondCirle = circles[1];

            Console.WriteLine(Circle.Intersect(firstCirle, secondCirle) ? "Yes" : "No");
        }

        static Point ReadPoint(int[] tokens)
        {
            Point currentPoint = new Point { X = tokens[0], Y = tokens[1] };

            return currentPoint;
        }
    }
}
