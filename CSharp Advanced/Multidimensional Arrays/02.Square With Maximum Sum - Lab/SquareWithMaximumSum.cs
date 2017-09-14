namespace _02.Square_With_Maximum_Sum___Lab
{
    using System;
    using System.Linq;

    public class SquareWithMaximumSum
    {
        public static void Main()
        {
            var matrixSizes = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new int[matrixSizes[0]][];

            for (int row = 0; row < matrixSizes[0]; row++)
            {
                matrix[row] = Console.ReadLine()
                        .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
            }

            var leftTop = 0;
            var rightTop = 0;
            var leftBottom = 0;
            var rightBottom = 0;
            var maxSum = int.MinValue;

            for (int row = 0; row < matrix.Length -1; row++)
            {
                for (int col = 0; col < matrix[0].Length - 1; col++)
                {
                    var currentSum = matrix[row][col] + matrix[row][col + 1] +
                                     matrix[row + 1][col] + matrix[row + 1][col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        leftTop = matrix[row][col];
                        rightTop = matrix[row][col + 1];
                        leftBottom = matrix[row + 1][col];
                        rightBottom = matrix[row + 1][col + 1];
                    }
                }
            }            
            Console.WriteLine($"{leftTop} {rightTop}");
            Console.WriteLine($"{leftBottom} {rightBottom}");
            Console.WriteLine(maxSum);
        }
    }
}

