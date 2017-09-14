namespace _7.Valid_Usernames
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                 .Split(new char[] { '(', ')', '/', '\\', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var regex = new Regex(@"\b[A-Za-z]\w{2,24}\b");
            var names = new List<string>();
            foreach (var name in input)
            {
                if (regex.IsMatch(name))
                {
                    names.Add(name);
                }
            }
            var sum = 0;
            var maxSum = 0;
            string firstUser = null;
            string secondUser = null;
            for (int i = 0; i < names.Count - 1; i++)
            {
                sum = names[i].Length + names[i + 1].Length;
                if (sum > maxSum)
                {
                    firstUser = names[i];
                    secondUser = names[i + 1];
                    maxSum = sum;
                }
           }
            Console.WriteLine(firstUser);
            Console.WriteLine(secondUser);
        }
    }
}
