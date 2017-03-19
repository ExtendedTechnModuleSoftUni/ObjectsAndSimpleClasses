namespace _05L.ClosestTwoPoints
{
    using System;
    using System.Linq;

    public class ClosestTwoPoints
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

        }
        public static void Main()
        {
            Point[] points = ReadPoints();
            Point[] closestPoints = FindClosestTwoPoints(points);
            PrintDistance(closestPoints);
            PrintPoints(closestPoints[0]);
            PrintPoints(closestPoints[1]);

        }

        private static void PrintPoints(Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }

        static void PrintDistance(Point[] closestPoints)
        {
            double distance = CalcDistance(closestPoints[0], closestPoints[1]);

            Console.WriteLine("{0:f3}", distance);
        }

        static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = int.MaxValue;

            Point[] closestTwoPoints = null;

            for (int firstPoints = 0; firstPoints < points.Length; firstPoints++)
            {
                for (int secondPoints = firstPoints + 1; secondPoints < points.Length; secondPoints++)
                {
                    double distance = CalcDistance(points[firstPoints], points[secondPoints]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[firstPoints], points[secondPoints] };
                    }
                }
            }

            return closestTwoPoints;
        }

        static double CalcDistance(Point point1, Point point2)
        {
            int deltaX = point2.X - point1.X;
            int deltaY = point2.Y - point1.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {

                points[i] = ReadPoint();
            }

            return points;
        }

        static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point point = new Point { X = pointInfo[0], Y = pointInfo[1] };

            return point;
        }
    }
}
