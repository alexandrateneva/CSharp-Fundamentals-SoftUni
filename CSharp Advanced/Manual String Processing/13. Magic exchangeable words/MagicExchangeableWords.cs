namespace _13.Magic_exchangeable_words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MagicExchangeableWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { '\r', '\t', ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            var dict = new Dictionary<char, char>();

            var str1 = input[0];
            var str2 = input[1];

            if (str1.Distinct().Count() != str2.Distinct().Count())
            {
                Console.WriteLine("false");
                return;
            }

            for (int i = 0; i < Math.Min(str1.Length, str2.Length); i++)
            {
                if (!dict.ContainsKey(str1[i]))
                {
                    dict.Add(str1[i], str2[i]);
                }
                else
                {
                    if (dict[str1[i]] != str2[i])
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }

            if (str1.Length != str2.Length)
            {
                string smallOne = null;
                string bigOne = null;

                if (str1.Length > str2.Length)
                {
                    smallOne = str2;
                    bigOne = str1;
                }
                else
                {
                    smallOne = str1;
                    bigOne = str2;
                }
                for (int i = smallOne.Length; i < bigOne.Length; i++)
                {
                    if (bigOne == str1 && !dict.ContainsKey(bigOne[i]))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                    else if (bigOne == str2 && !dict.ContainsValue(bigOne[i]))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }

            Console.WriteLine("true");
        }
    }
}
