namespace _6.A_miner_task
{
    using System;
    using System.Collections.Generic;

    public class MinerTask
    {
        public static void Main()
        {
            var resources = new Dictionary<string, double>();

            while (true)
            {
                var resourse = Console.ReadLine();
                if (resourse == "stop")
                {
                    break;
                }
                var quantity = double.Parse(Console.ReadLine());
                if (!resources.ContainsKey(resourse))
                {
                    resources[resourse] = quantity;
                }
                else
                {
                    resources[resourse] += quantity;
                }
            }
            foreach (var resourse in resources)
            {
                Console.WriteLine($"{resourse.Key} -> {resourse.Value}");
            }
        }
    }
}
