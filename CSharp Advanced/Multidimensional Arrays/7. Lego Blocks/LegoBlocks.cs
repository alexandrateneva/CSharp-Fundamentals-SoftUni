namespace _7.Lego_Blocks
{
    using System;
    using System.Linq;

    public class LegoBlocks
    {
        public static void Main()
        {
            var rows = int.Parse(Console.ReadLine().Trim());
            var firstMatrix = new int[rows][];
            var secondMatrix = new int[rows][];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    var line = Console.ReadLine()
                        .Trim()
                        .Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                    if (i == 0)
                    {
                        firstMatrix[j] = new int[line.Length];
                        firstMatrix[j] = line;
                    }
                    else
                    {
                        secondMatrix[j] = new int[line.Length];
                        secondMatrix[j] = line;
                    }

                }
            }

            for (int i = 0; i < rows; i++)
            {
                var newLine = secondMatrix[i].Reverse().ToArray();
                secondMatrix[i] = newLine;
            }

            var totalSum = 0;
            var previousSum = firstMatrix[0].Length + secondMatrix[0].Length;
            var isRectange = true;

            for (int i = 0; i < rows; i++)
            {
                var sumALine = firstMatrix[i].Length + secondMatrix[i].Length;
                totalSum += sumALine;
                if (previousSum != sumALine)
                {
                    isRectange = false;
                }
                previousSum = sumALine;
            }

            if (isRectange)
            {
                for (int i = 0; i < rows; i++)
                {
                    var a = string.Join(", ", firstMatrix[i]);
                    var b = string.Join(", ", secondMatrix[i]);
                    Console.WriteLine($"[{a}, {b}]");
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {totalSum}");
            }
        }
    }
}
