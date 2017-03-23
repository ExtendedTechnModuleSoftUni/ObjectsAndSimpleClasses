namespace _05E.Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    public class Box
    {
        public Point UpperLeft { get; set; }

        public Point UpperRight { get; set; }

        public Point BottomLeft { get; set; }

        public Point BottomRight { get; set; }

        public double Width
        {
            get
            {
                return Point.CalcDistance(UpperLeft, UpperRight);
            }
        }

        public double Height
        {
            get
            {
                return Point.CalcDistance(UpperLeft, BottomLeft);
            }
        }

        public static int CalculatePerimeter(double width, double height)
        {
            return (int)((2 * width) + (2 * height));
        }

        public static int CalculateArea(double width, double height)
        {
            return (int)(width * height);
        }
    }

    public class Boxes
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var boxes = new List<Box>();

            while (inputLine != "end")
            {
                var tokens = inputLine
                    .Split(new char[] { ' ', '|' }
                    , StringSplitOptions.RemoveEmptyEntries);

                var points = new List<Point>();

                foreach (var coordinate in tokens)
                {
                    var currentXandY = coordinate.Split(':').Select(int.Parse).ToArray();
                    var currentPoint = new Point { X = currentXandY[0], Y = currentXandY[1] };
                    points.Add(currentPoint);
                }

                var currentBox = new Box
                {
                    UpperLeft = points[0],
                    UpperRight = points[1],
                    BottomLeft = points[2],
                    BottomRight = points[3]
                };

                boxes.Add(currentBox);

                inputLine = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                Console.WriteLine($"Box: {box.Width}, {box.Height}");
                Console.WriteLine($"Perimeter: {Box.CalculatePerimeter(box.Width, box.Height)}");
                Console.WriteLine($"Area: {Box.CalculateArea(box.Width, box.Height)}");
            }
        }
    }
}
