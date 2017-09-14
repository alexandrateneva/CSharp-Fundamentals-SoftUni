namespace _1.Action_Print
{
    using System;

    public class ActionPrint
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(' ');
            Action<string> print = name => Console.WriteLine(name);

            foreach (var name in names)
            {
                print(name);
            }
        }
    }
}
