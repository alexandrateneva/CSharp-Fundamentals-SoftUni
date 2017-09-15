namespace _03.Cubic_Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class CubicMessages
    {
        public static void Main()
        {
            var result = new List<string[]>();
            var regex = new Regex(@"^(\d+)([A-Za-z]+)(?:([^A-Za-z]+\d*?)+)?$");
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Over!")
                {
                    break;
                }
                var match = regex.Match(input);
                if (match.Success)
                {
                    var n = int.Parse(Console.ReadLine());
                    if (match.Groups[2].Value.Length == n)
                    {
                        var numbers = match.Groups[1].Value.ToList();
                        var digits = numbers.Select(num => int.Parse(num.ToString())).ToList();
                        foreach (var symbol in match.Groups[3].Value)
                        {
                            if (char.IsDigit(symbol))
                            {
                                var num = int.Parse(symbol.ToString());
                                digits.Add(num);
                            }
                        }

                        var code = new StringBuilder();
                        var message = match.Groups[2].Value;
                        foreach (var digit in digits)
                        {
                            if (digit >= 0 && digit < message.Length)
                            {
                                var letter = message[digit];
                                code.Append(letter);
                            }
                            else
                            {
                                code.Append(' ');
                            }
                        }
                        var arr = new string[2];
                        arr[0] = message;
                        arr[1] = code.ToString();
                        result.Add(arr);
                    }
                }

            }
            foreach (var message in result)
            {
                Console.WriteLine($"{message[0]} == {message[1]}");
            }
        }
    }
}
