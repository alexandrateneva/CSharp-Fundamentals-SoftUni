namespace _01.Jedi_Meditation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class JediMeditation
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var masterYoda = false;
            var master = new Queue<string>();
            var knight = new Queue<string>();
            var padawan = new Queue<string>();
            var toshkoAndSlav = new Queue<string>();
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ').ToList();
                foreach (var token in tokens)
                {
                    switch (token[0])
                    {
                        case 'm': master.Enqueue(token); break;
                        case 'k': knight.Enqueue(token); break;
                        case 'p': padawan.Enqueue(token); break;
                        case 'y': masterYoda = true; break;
                        case 's': toshkoAndSlav.Enqueue(token); break;
                        case 't': toshkoAndSlav.Enqueue(token); break;
                    }
                }
            }
            var result = new StringBuilder();

            if (!masterYoda)
            {
                foreach (var jedy in toshkoAndSlav)
                {
                    result.Append(jedy).Append(" ");
                }
            }
            foreach (var jedy in master)
            {
                result.Append(jedy).Append(" ");
            }
            foreach (var jedy in knight)
            {
                result.Append(jedy).Append(" ");
            }
            if (masterYoda)
            {
                foreach (var jedy in toshkoAndSlav)
                {
                    result.Append(jedy).Append(" ");
                }
            }
            foreach (var jedy in padawan)
            {
                result.Append(jedy).Append(" ");
            }
            result.Length = result.Length - 1;
            Console.WriteLine(result);
        }
    }
}
