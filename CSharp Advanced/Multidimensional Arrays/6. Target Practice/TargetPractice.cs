namespace _6.Target_Practice
{
    using System;
    using System.Linq;

    public class TargetPractice
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var rows = int.Parse(dimentions[0]);
            var cols = int.Parse(dimentions[1]);

            var snake = Console.ReadLine().Trim().ToCharArray();

            var shot = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var matrix = new char[rows][];

            var index = 0;
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new char[cols];
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row % 2 == 0)
                    {
                        matrix[rows - 1 - row][cols - 1 - col] = snake[index];
                    }
                    else
                    {
                        matrix[rows - 1 - row][col] = snake[index];
                    }

                    index++;
                    if (index == snake.Length)
                    {
                        index = 0;
                    }
                }
            }

            var impactRow = int.Parse(shot[0]);
            var impactCol = int.Parse(shot[1]);
            var radius = int.Parse(shot[2]);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int deltaRow = row - impactRow;
                    int deltaCol = col - impactCol;

                    if (deltaRow * deltaRow + deltaCol * deltaCol <= radius * radius)
                    {
                        matrix[row][col] = ' ';
                    }
                }
            }

            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                for (int column = 0; column < cols; column++)
                {
                    if (matrix[row][column] != ' ')
                    {
                        continue;
                    }

                    int currentRow = row - 1;
                    while (currentRow >= 0)
                    {
                        if (matrix[currentRow][column] != ' ')
                        {
                            matrix[row][column] = matrix[currentRow][column];
                            matrix[currentRow][column] = ' ';
                            break;
                        }

                        currentRow--;
                    }
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}
