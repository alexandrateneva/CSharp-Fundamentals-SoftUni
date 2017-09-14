namespace _01.Sum_Matrix_Elements___Lab
{
    using System;
    using System.Linq;

    public class SumMatrixElements
    {
        public static void Main()
        {
            var matrixSizes = Console.ReadLine()
                 .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            var sum = 0;

            for (int i = 0; i < matrixSizes[0]; i++)
            {

                var row = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                sum += row.Sum();

            }
            Console.WriteLine(matrixSizes[0]);
            Console.WriteLine(matrixSizes[1]);
            Console.WriteLine(sum);
        }
    }
}
