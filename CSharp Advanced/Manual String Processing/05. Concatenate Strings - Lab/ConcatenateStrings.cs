namespace _05.Concatenate_Strings___Lab
{
    using System;
    using System.Text;

    public class ConcatenateStrings
    {
       public static void Main()
        {
            var result = new StringBuilder();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                result.Append(Console.ReadLine()).Append(" ");
            }
            Console.WriteLine(result);
        }
    }
}
