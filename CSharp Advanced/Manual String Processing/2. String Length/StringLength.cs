namespace _2.String_Length
{
    using System;

    public class StringLength
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            if (input.Length >= 20)
            {
                Console.WriteLine(input.Substring(0, 20));
            }
            else
            {
                Console.WriteLine(input.PadRight(20, '*'));
            }
        }
    }
}
