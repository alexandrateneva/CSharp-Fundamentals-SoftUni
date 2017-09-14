namespace _12.Little_John
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class LittleJohn
    {
        public static void Main()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                sb.Append(Console.ReadLine()).Append(" ");
            }

            var smallArrow = @">----->";
            var mediumArrow = @">>----->";
            var largeArrow = @">>>----->>";

            var text = sb.ToString();
            var large = Regex.Matches(text, largeArrow).Count;
            text = Regex.Replace(text, largeArrow, " ");
            var medium = Regex.Matches(text, mediumArrow).Count;
            text = Regex.Replace(text, mediumArrow, " ");
            var small = Regex.Matches(text, smallArrow).Count;

            var numDec = string.Concat(small.ToString(), medium.ToString(), large.ToString());
            var numBin = Convert.ToString(int.Parse(numDec), 2);
            var arr = numBin.ToCharArray();
            Array.Reverse(arr);
            var reversed = new string(arr);
            var numBinSec = string.Concat(numBin, reversed);
            var result = Convert.ToInt32(numBinSec, 2);
            Console.WriteLine(result);
        }
    }
}
