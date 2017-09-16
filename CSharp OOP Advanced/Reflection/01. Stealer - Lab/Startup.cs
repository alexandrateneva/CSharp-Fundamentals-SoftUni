namespace _01.Stealer___Lab
{
    using System;
    using _01.Stealer___Lab.Models;

    public class Startup
    {
        public static void Main()
        {
            Spy spy = new Spy();
            string result = spy.StealFieldInfo("Hacker", "username", "password");
            Console.WriteLine(result);
        }
    }
}
