namespace _9.Crossfire
{
    using System;
    using System.Linq;

    public class Crossfire
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var rows = int.Parse(dimentions[0]);
            var cols = int.Parse(dimentions[1]);


            var matrix = new int[rows][];
            var number = 1;
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = number;
                    number++;
                }
            }

            var input = Console.ReadLine();
            while (input != "Nuke it from orbit")
            {
                var shot = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var shotRow = shot[0];
                var shotCol = shot[1];
                var shotRadius = shot[2];

                for (int row = shotRow - shotRadius; row <= shotRow + shotRadius; row++)
                {
                    if (row >= 0 && shotCol >= 0 && row < matrix.Length && shotCol < matrix[row].Length)
                    {
                        matrix[row][shotCol] = -1;
                    }
                }

                for (int col = shotCol - shotRadius; col <= shotCol + shotRadius; col++)
                {
                    if (shotRow >= 0 && col >= 0 && shotRow < matrix.Length && col < matrix[shotRow].Length)
                    {
                        matrix[shotRow][col] = -1;
                    }
                }

                // Remove destroyed cells
                for (int i = 0; i < matrix.Length; i++)
                {
                    // Remove destroyed cells if there is ones
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] < 0)
                        {
                            matrix[i] = matrix[i].Where(n => n > 0).ToArray();
                        }
                    }

                    // Remove empty rows
                    if (matrix[i].Count() < 1)
                    {
                        matrix = matrix.Take(i).Concat(matrix.Skip(i + 1)).ToArray();
                        i--;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}