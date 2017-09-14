namespace _13.TriFunction
{
    using System;

    public class TriFunction
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(' ');
            foreach (var name in names)
            {
                var sum = 0;
                foreach (var letter in name)
                {
                    sum += letter;
                }
                if (sum >= number)
                {
                    Console.WriteLine(name);
                    return;
                }
            }
        }
    }
}
