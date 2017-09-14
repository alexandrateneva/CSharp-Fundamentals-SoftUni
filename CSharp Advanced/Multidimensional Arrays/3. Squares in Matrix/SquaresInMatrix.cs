namespace _3.Squares_in_Matrix
{
    using System;
    using System.Linq;

    public class SquaresInMatrix
    {
        public static void Main()
        {
            var dimension = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new string[dimension[0]][];
            for (int row = 0; row < dimension[0]; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
            var counter = 0;
            for (int row = 1; row < dimension[0]; row++)
            {
                for (int col = 1; col < dimension[1]; col++)
                {
                    var a = matrix[row - 1][col - 1];
                    var b = matrix[row - 1][col];
                    var c = matrix[row][col - 1];
                    var d = matrix[row][col];
                    if (a.Equals(b) && b.Equals(c) && c.Equals(d))
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
