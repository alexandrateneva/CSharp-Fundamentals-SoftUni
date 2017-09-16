namespace _04.Collector___Lab
{
    using System;
    using _04.Collector___Lab.Models;

    public class Startup
    {
        public static void Main()
        {
            Spy spy = new Spy();
            string result = spy.CollectGettersAndSetters("Hacker");
            Console.WriteLine(result);
        }
    }
}
