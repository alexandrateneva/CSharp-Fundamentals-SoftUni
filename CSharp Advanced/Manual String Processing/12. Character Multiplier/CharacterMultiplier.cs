namespace _12.Character_Multiplier
{
    using System;
    using System.Numerics;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { '\r', '\t', ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            var str1 = input[0];
            var str2 = input[1];
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

            BigInteger result = new BigInteger();

            for (int i = 0; i < smallOne.Length; i++)
            {
                result += str1[i] * str2[i];
            }
            for (int i = 0; i < bigOne.Length - smallOne.Length; i++)
            {
                result += bigOne[smallOne.Length + i];
            }

            Console.WriteLine(result);
        }
    }
}

