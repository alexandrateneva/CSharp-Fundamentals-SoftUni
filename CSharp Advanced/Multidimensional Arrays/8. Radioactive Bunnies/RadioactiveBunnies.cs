namespace _8.Radioactive_Bunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RadioactiveBunnies
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];
            var indexPlayer = new int[2];

            var matrix = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
                if (matrix[i].Contains('P'))
                {
                    indexPlayer[0] = i;
                    indexPlayer[1] = Array.IndexOf(matrix[i], 'P');
                }
            }
            var isAlive = true;
            var isWinner = false;
            var commands = Console.ReadLine().ToCharArray();
            for (int i = 0; i < commands.Length && !isWinner && isAlive; i++)
            {
                switch (commands[i])
                {
                    case 'R':
                        if (indexPlayer[1] + 1 > matrix[0].Length - 1)
                        {
                            isWinner = true;
                            matrix[indexPlayer[0]][indexPlayer[1]] = '.';
                            indexPlayer[1] = matrix[0].Length - 1;
                        }
                        else
                        {
                            if (matrix[indexPlayer[0]][indexPlayer[1] + 1] == 'B')
                            {                               
                                isAlive = false;
                            }
                            else
                            {
                                matrix[indexPlayer[0]][indexPlayer[1] + 1] = 'P';
                                matrix[indexPlayer[0]][indexPlayer[1]] = '.';
                            }
                            indexPlayer[1]++;
                        }
                        break;
                    case 'L':
                        if (indexPlayer[1] - 1 < 0)
                        {
                            isWinner = true;
                            matrix[indexPlayer[0]][indexPlayer[1]] = '.';
                            indexPlayer[1] = 0;  
                        }
                        else
                        {
                            if (matrix[indexPlayer[0]][indexPlayer[1] - 1] == 'B')
                            {
                                isAlive = false;
                            }
                            else
                            { 
                                matrix[indexPlayer[0]][indexPlayer[1] - 1] = 'P';
                                matrix[indexPlayer[0]][indexPlayer[1]] = '.';
                            }
                            indexPlayer[1]--;
                        }
                        break;
                    case 'U':
                        if (indexPlayer[0] - 1 < 0)
                        {
                            isWinner = true;
                            matrix[indexPlayer[0]][indexPlayer[1]] = '.';
                            indexPlayer[0] = 0;
                        }
                        else
                        {
                            if (matrix[indexPlayer[0] - 1][indexPlayer[1]] == 'B')
                            {
                                isAlive = false;
                            }
                            else
                            {
                                matrix[indexPlayer[0] - 1][indexPlayer[1]] = 'P';
                                matrix[indexPlayer[0]][indexPlayer[1]] = '.';
                            }
                            indexPlayer[0]--;
                        }
                        break;
                    case 'D':
                        if (indexPlayer[0] + 1 > matrix.Length - 1)
                        {
                            isWinner = true;
                            matrix[indexPlayer[0]][indexPlayer[1]] = '.';
                            indexPlayer[0] = matrix.Length - 1;
                        }
                        else
                        {
                            if (matrix[indexPlayer[0] + 1][indexPlayer[1]] == 'B')
                            {
                                isAlive = false;
                            }
                            else
                            {
                                matrix[indexPlayer[0] + 1][indexPlayer[1]] = 'P';
                                matrix[indexPlayer[0]][indexPlayer[1]] = '.';
                            }
                            indexPlayer[0]++;
                        }
                        break;
                }

                var bunnieIndexes = new Dictionary<int, List<int>>();

                for (int j = 0; j < rows; j++)
                {
                    bunnieIndexes.Add(j, new List<int>());
                    for (int k = 0; k < cols; k++)
                    {
                        if (matrix[j][k] == 'B')
                        {
                            bunnieIndexes[j].Add(k);
                        }
                    }
                }

                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < cols; k++)
                    {
                        if (bunnieIndexes.ContainsKey(j) && bunnieIndexes[j].Contains(k))
                        {
                            if (k + 1 < matrix[j].Length)
                            {
                                if (matrix[j][k + 1] == 'P')
                                {
                                    isAlive = false;
                                }
                                matrix[j][k + 1] = 'B';
                            }

                            if (k - 1 >= 0)
                            {
                                if (matrix[j][k - 1] == 'P')
                                {
                                    isAlive = false;
                                }
                                matrix[j][k - 1] = 'B';
                            }

                            if (j - 1 >= 0)
                            {
                                if (matrix[j - 1][k] == 'P')
                                {
                                    isAlive = false;
                                }
                                matrix[j - 1][k] = 'B';
                            }

                            if (j + 1 < matrix.Length)
                            {
                                if (matrix[j + 1][k] == 'P')
                                {
                                    isAlive = false;
                                }
                                matrix[j + 1][k] = 'B';
                            }

                        }
                    }
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
            if (isAlive)
            {
                Console.WriteLine($"won: {indexPlayer[0]} {indexPlayer[1]}");
            }
            else
            {
                Console.WriteLine($"dead: {indexPlayer[0]} {indexPlayer[1]}");
            }
        }
    }
}

