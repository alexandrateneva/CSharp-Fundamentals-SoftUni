namespace _02.Jedi_Galaxy
{
    using System;
    using System.Linq;

    public class JediGalaxy
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            var rows = dimentions[0];
            var cols = dimentions[1];

            var matrix = new long[rows][];
            var counter = 0;
            for (long r = 0; r < rows; r++)
            {
                matrix[r] = new long[cols];
                for (long c = 0; c < cols; c++)
                {
                    matrix[r][c] = counter;
                    counter++;
                }
            }
            long sum = 0;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Let the Force be with you")
                {
                    break;
                }
                var ivoCoordinates = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();
                var ivoRow = ivoCoordinates[0];
                var ivoCol = ivoCoordinates[1];
                if (ivoRow >= rows)
                {
                    var shiftValue = ivoRow - rows + 1;
                    ivoRow -= shiftValue;
                    ivoCol += shiftValue;
                }

                if (ivoCol < 0)
                {
                    var shiftValue = Math.Abs(ivoCol);
                    ivoRow -= shiftValue;
                    ivoCol += shiftValue;
                }

                var evilCoordinates = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();
                var evilRow = evilCoordinates[0];
                var evilCol = evilCoordinates[1];
                if (evilCol >= cols)
                {
                    var shiftValue = evilCol - cols + 1;
                    evilRow -= shiftValue;
                    evilCol -= shiftValue;
                }
                if (evilRow >= rows)
                {
                    var shiftValue = evilRow - rows + 1;
                    evilRow -= shiftValue;
                    evilCol -= shiftValue;
                }

                while (evilRow >= 0 && evilCol >= 0)
                {
                    matrix[evilRow][evilCol] = 0;
                    evilRow--;
                    evilCol--;
                }

                while (ivoRow >= 0 && ivoCol < cols)
                {
                    sum += matrix[ivoRow][ivoCol];
                    ivoRow--;
                    ivoCol++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
