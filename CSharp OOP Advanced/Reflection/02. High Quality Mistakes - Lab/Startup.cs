namespace _02.High_Quality_Mistakes___Lab
{
    using System;
    using _02.High_Quality_Mistakes___Lab.Models;

    public class Startup
    {
        public static void Main()
        {
            Spy spy = new Spy();
            string result = spy.AnalyzeAcessModifiers("Hacker");
            Console.WriteLine(result);
        }
    }
}
