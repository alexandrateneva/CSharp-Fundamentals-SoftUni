namespace _03.Mission_Private_Impossible___Lab
{
    using System;
    using _03.Mission_Private_Impossible___Lab.Models;

    public class Startup
    {
        public static void Main()
        {
            Spy spy = new Spy();
            string result = spy.RevealPrivateMethods("Hacker");
            Console.WriteLine(result);
        }
    }
}
