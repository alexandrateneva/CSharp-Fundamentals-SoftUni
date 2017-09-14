namespace _15.Melrah_Shake
{
    using System;

    public class MelrahShake
    {
        public static void Main()
        {

            var text = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (true)
            {
                var firstMatchIndex = text.IndexOf(pattern);
                var secondMatchIndex = text.LastIndexOf(pattern);

                var canShake = firstMatchIndex > -1
                               && secondMatchIndex > -1
                               && pattern.Length > 0;

                if (!canShake)
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(text);
                    break;
                }

                text = text.Remove(firstMatchIndex, pattern.Length);
                text = text.Remove(secondMatchIndex - pattern.Length, pattern.Length);
                pattern = pattern.Remove(pattern.Length / 2, 1);

                Console.WriteLine("Shaked it.");
            }
        }
    }
}
