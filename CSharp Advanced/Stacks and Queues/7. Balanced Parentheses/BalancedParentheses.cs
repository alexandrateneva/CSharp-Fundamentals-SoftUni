namespace _7.Balanced_Parentheses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BalancedParentheses
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var opened = new Stack<char>();
            var opening = new char[] { '{', '[', '(' };

            for (int i = 0; i < input.Length; i++)
            {
                if (opening.Contains(input[i]))
                {
                    opened.Push(input[i]);
                }
                else
                {
                    if (opened.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    switch (input[i])
                    {
                        case '}':
                            if (opened.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ')':
                            if (opened.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ']':
                            if (opened.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
