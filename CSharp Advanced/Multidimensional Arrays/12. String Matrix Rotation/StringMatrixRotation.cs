namespace _12.String_Matrix_Rotation
{
    using System;
    using System.Collections.Generic;

    public class StringMatrixRotation
    {
        public static void Main()
        {
            var rotate = Console.ReadLine();
            var integer = rotate.Split('(');
            integer[1] = integer[1].Remove(integer[1].Length - 1, 1);
            var degrees = int.Parse(integer[1]);
            var input = Console.ReadLine();
            var elements = new List<string>();
            var longestWord = 0;

            while (input != "END")
            {
                elements.Add(input);
                if (longestWord < input.Length)
                {
                    longestWord = input.Length;
                }
                input = Console.ReadLine();
            }

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].Length < longestWord)
                {
                    elements[i] = elements[i] + new string(' ', longestWord - elements[i].Length);
                }
            }

            if (degrees == 180 || degrees % 360 == 180)
            {
                for (int i = elements.Count - 1; i >= 0; i--)
                {
                    for (int j = elements[i].Length - 1; j >= 0; j--)
                    {
                        Console.Write(elements[i][j]);
                    }
                    Console.WriteLine();
                }
            }

            char[,] rotate90 = new char[longestWord, elements.Count];

            for (int row = 0; row < longestWord; row++)
            {
                for (int col = 0; col < elements.Count; col++)
                {
                    rotate90[row, col] = elements[col][row];
                }
            }

            if (degrees == 270 || degrees % 360 == 270)
            {

                for (int i = rotate90.GetLength(0) - 1; i >= 0; i--)
                {
                    for (int j = 0; j < rotate90.GetLength(1); j++)
                    {
                        Console.Write(rotate90[i, j]);
                    }
                    Console.WriteLine();
                }
            }

            if (degrees == 90 || degrees % 360 == 90)
            {
                for (int i = 0; i < rotate90.GetLength(0); i++)
                {
                    for (int j = rotate90.GetLength(1) - 1; j >= 0; j--)
                    {
                        Console.Write(rotate90[i, j]);
                    }
                    Console.WriteLine();
                }
            }

            if (degrees == 0 || degrees % 360 == 0)
            {
                foreach (var rotate360 in elements)
                {
                    Console.WriteLine(rotate360);
                }
            }
        }
    }
}

