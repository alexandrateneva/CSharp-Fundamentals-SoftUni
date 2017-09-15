namespace _8.Rectangle_Intersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var tokens = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var numberOfRectangles = tokens[0];
            var numberOfPairs = tokens[1];
            var rectangles = new Dictionary<string, Rectangle>();

            for (int i = 0; i < numberOfRectangles; i++)
            {
                var rectangleInfo = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var currentRectangle = new Rectangle(
                    double.Parse(rectangleInfo[1]),
                    double.Parse(rectangleInfo[2]),
                    double.Parse(rectangleInfo[3]),
                    double.Parse(rectangleInfo[4]));

                rectangles.Add(rectangleInfo[0], currentRectangle);
            }

            for (int i = 0; i < numberOfPairs; i++)
            {
                var twoRectanglesID = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var firstRectangle = rectangles[twoRectanglesID[0]];
                var secondRectangle = rectangles[twoRectanglesID[1]];
                Console.WriteLine(firstRectangle.TheyIntersect(secondRectangle));
            }
        }
    }
}
