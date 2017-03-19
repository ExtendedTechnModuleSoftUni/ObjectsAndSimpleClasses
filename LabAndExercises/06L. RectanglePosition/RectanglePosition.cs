namespace _06L.RectanglePosition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RectanglePosition
    {
        class Rectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public int Bottom
            {
                get
                {
                    return Top + Height;
                }
            }
            public int Right
            {
                get
                {
                    return Left + Width;
                }
            }
            public bool isInside(Rectangle rectangle)
            {
                var leftIsValid = rectangle.Left <= Left;
                var topIsValid = rectangle.Top <= Top;
                var rightIsValid = rectangle.Right >= Right;
                var bottomIsValid = rectangle.Bottom >= Bottom;

                return leftIsValid
                    && topIsValid
                    && rightIsValid
                    && bottomIsValid;
            }
        }

        public static void Main()
        {
            Rectangle firstRect = ReadRectangle();
            Rectangle secondRect = ReadRectangle();

            Console.WriteLine(firstRect.isInside(secondRect) ? "Inside" : "Not inside");
        }

        static Rectangle ReadRectangle()
        {
            var rectangleProperties = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var rectangle = new Rectangle
            {
                Left = rectangleProperties[0],
                Top = rectangleProperties[1],
                Width = rectangleProperties[2],
                Height = rectangleProperties[3]
            };

            return rectangle;
        }
    }
}
