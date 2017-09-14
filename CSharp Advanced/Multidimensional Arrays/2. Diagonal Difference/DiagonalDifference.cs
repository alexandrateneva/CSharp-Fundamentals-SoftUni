namespace _2.Diagonal_Difference
{
    using System;
    using System.Linq;

    public class DiagonalDifference
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var matrix = new int[n][];
            for (int rowIndex = 0; rowIndex < n; rowIndex++)
            {
                matrix[rowIndex] = Console.ReadLine()
                    .Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries )
                    .Select(int.Parse)
                    .ToArray();

            }
            var primaryDiagonal = 0;
            var secondaryDiagonal = 0;
            var colFirst = 0;
            var colSecond = n - 1;
            for (int row = 0; row < n; row++)
            {
                primaryDiagonal += matrix[row][colFirst];
                secondaryDiagonal += matrix[row][colSecond];
                colFirst++;
                colSecond--;
            }
            var result = Math.Abs(primaryDiagonal - secondaryDiagonal);
            Console.WriteLine(result);
        }
    }
}
