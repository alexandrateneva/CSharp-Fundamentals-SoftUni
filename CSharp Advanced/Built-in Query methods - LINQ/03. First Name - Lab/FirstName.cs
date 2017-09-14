namespace _03.First_Name___Lab
{
    using System;
    using System.Linq;

    public class FirstName
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(' ');
            var letters = Console.ReadLine().Split(' ').OrderBy(n => n);
            string result = null;
            foreach (var letter in letters)
            {
                result = names.FirstOrDefault(n => n.ToLower().StartsWith(letter.ToLower()));
                if (result != null)
                {
                    Console.WriteLine(result);
                    break;
                }
            }
            if (result == null)
            {
                Console.WriteLine("No match");
            }
        }
    }
}
