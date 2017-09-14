namespace _2.Knights_of_Honor
{
    using System;

    public class KnightsOfHonor
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(' ');
            Action<string> print = name => Console.WriteLine(string.Concat("Sir ", name));
            foreach (var name in names)
            {
                print(name);
            }
        }
    }
}
