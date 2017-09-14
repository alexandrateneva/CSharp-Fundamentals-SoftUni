namespace _4.Maximal_Sum
{
    using System;
    using System.Linq;

    public class MaximalSum
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new int[dimentions[0]][];
            for (int row = 0; row < dimentions[0]; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var finalFirstRow = new int[3];
            var finalSecondRow = new int[3];
            var finalThirdRow = new int[3];
            var maxSum = 0;
            for (int row = 0; row < dimentions[0] - 2; row++)
            {
                for (int col = 0; col < dimentions[1] - 2; col++)
                {
                   var firstRow = matrix[row].Skip(col).Take(3).ToArray();
                   var secondRow = matrix[row + 1].Skip(col).Take(3).ToArray();
                   var thirdRow = matrix[row + 2].Skip(col).Take(3).ToArray();
                    var sum = firstRow.Sum() + secondRow.Sum() + thirdRow.Sum();
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        finalFirstRow = firstRow;
                        finalSecondRow = secondRow;
                        finalThirdRow = thirdRow;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine(string.Join(" ", finalFirstRow));
            Console.WriteLine(string.Join(" ", finalSecondRow));
            Console.WriteLine(string.Join(" ", finalThirdRow));
        }
    }
}
