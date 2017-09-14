namespace _5.Rubiks_Matrix
{
    using System;
    using System.Linq;

    public class RubiksMatrix
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine()
                .Trim()
                .Split(new char[] { ' ', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];
            var matrix = new int[dimentions[0]][];
            var number = 1;
            for (int row = 0; row < dimentions[0]; row++)
            {
                matrix[row] = new int[dimentions[1]];
                for (int col = 0; col < dimentions[1]; col++)
                {
                    matrix[row][col] = number;
                    number++;
                }
            }

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (input.Length == 3)
                {
                    var rowOrCol = int.Parse(input[0]);
                    var direction = input[1].ToLower();
                    var moves = int.Parse(input[2]);

                    if (direction == "left" || direction == "right")
                    {
                        moves %= cols;
                        if (direction == "right") moves = cols - moves;
                        for (int m = 0; m < moves % cols; m++)
                        {
                            for (int j = 0; j < cols - 1; j++)
                            {
                                int temp = matrix[rowOrCol][j];
                                matrix[rowOrCol][j] = matrix[rowOrCol][j + 1];
                                matrix[rowOrCol][j + 1] = temp;
                            }
                        }
                    }
                    else
                    {
                        moves %= rows;
                        if (direction == "down") moves = rows - moves;
                        for (int m = 0; m < moves % rows; m++)
                        {
                            for (int j = 0; j < rows - 1; j++)
                            {
                                int temp = matrix[j][rowOrCol];
                                matrix[j][rowOrCol] = matrix[j + 1][rowOrCol];
                                matrix[j + 1][rowOrCol] = temp;
                            }
                        }
                    }
                }
            }
            var helpfulNum = 1;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row][col] != helpfulNum)
                    {
                        var colIndex = 0;
                        var rowIndex = 0;
                        var oldNum = matrix[row][col];
                        var newNum = 0;

                        for (int k = 0; k < rows; k++)
                        {
                            for (int j = 0; j < cols; j++)
                            {
                                if (matrix[k][j] == helpfulNum)
                                {
                                    rowIndex = k;
                                    colIndex = j;
                                    newNum = matrix[k][j];
                                }
                            }
                        }

                        Console.WriteLine($"Swap ({row}, {col}) with ({rowIndex}, {colIndex})");
                        matrix[rowIndex][colIndex] = oldNum;
                        matrix[row][col] = newNum;
                    }
                    else
                    {
                        Console.WriteLine($"No swap required");
                    }
                    helpfulNum++;
                }
            }
        }
    }
}