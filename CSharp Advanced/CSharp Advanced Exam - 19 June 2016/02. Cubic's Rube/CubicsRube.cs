namespace _02.Cubic_s_Rube
{
    using System;
    using System.Linq;

    public class CubicsRube
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            var matrix = new int[n][][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n][];
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = new int[n];
                    for (int k = 0; k < n; k++)
                    {
                        matrix[i][j][k] = 0;
                    }
                }
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Analyze")
                {
                    break;
                }

                var commands = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (commands[0] < 0 || commands[1] < 0 || commands[2] < 0)
                {
                    continue;

                }
                matrix[commands[0]][commands[1]][commands[2]] = commands[3];
            }

            long sum = 0;
            long counter = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int cel = 0; cel < matrix[row].Length; cel++)
                {
                    for (int kit = 0; kit < matrix[row][cel].Length; kit++)
                    {
                        sum += matrix[row][cel][kit];
                        if (matrix[row][cel][kit] == 0)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(counter);
        }
    }
}
