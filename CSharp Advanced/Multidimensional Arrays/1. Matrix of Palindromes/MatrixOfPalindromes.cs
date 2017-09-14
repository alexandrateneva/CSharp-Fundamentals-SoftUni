namespace _1.Matrix_of_Palindromes
{
    using System;
    using System.Linq;

    public class MatrixOfPalindromes
    {
        public static void Main()
        {
            var n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result = new string[n[0]][];
            var alp = "abcdefghijklmnopqrstuvwxyz";

            for (int row = 0; row < n[0]; row++)
            {
                var firstAndLast = alp[row];
                result[row] = new string[n[1]];
                var second = alp[row];

                for (int col = 0; col < n[1]; col++)
                {
                    var current = new char[] { firstAndLast, second, firstAndLast };
                    var currentAsStr = new string(current);
                    result[row][col] = currentAsStr;
                    second++;
                }
            }
            foreach (var row in result)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
