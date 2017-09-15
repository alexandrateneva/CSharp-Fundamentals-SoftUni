namespace _02.Nature_s_Prophet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class NaturesProphet
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var side = dimentions[0];

            var matrix = new int[side][];
            for (int i = 0; i < side; i++)
            {
                matrix[i] = new int[side];
                for (int j = 0; j < side; j++)
                {
                    matrix[i][j] = 0;
                }
            }
            var coordinates = new List<int[]>();
            var input = Console.ReadLine();
            while (input != "Bloom Bloom Plow")
            {
                coordinates.Add(input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray());
                input = Console.ReadLine();
            }

            foreach (var position in coordinates.OrderBy(n => n[0]).ThenBy(n => n[1]))
            {
                var row = position[0];
                var col = position[1];
                for (int i = 0; i < side; i++)
                {
                    if (i != row)
                    {
                        matrix[i][col]++;
                    }
                    matrix[row][i]++;
                }
            }

            var sb = new StringBuilder();
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    sb.Append(matrix[i][j]).Append(" ");
                }
                sb.Append("\n");
            }
            sb.Length -= 1;
            Console.WriteLine(sb);
        }
    }
}

