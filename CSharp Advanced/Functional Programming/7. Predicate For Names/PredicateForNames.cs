namespace _7.Predicate_For_Names
{
    using System;
    using System.Linq;

    public class PredicateForNames
    {
        public static void Main()
        {
            var len = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(' ').ToArray();
            Predicate<string> isShorter = name => name.Length <= len;
            foreach (var name in names)
            {
                if (isShorter(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
