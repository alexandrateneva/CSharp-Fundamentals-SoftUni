namespace _3.Telephony
{
    using System;
    using System.Linq;
    using _3.Telephony.Models;

    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').ToList();
            var urls = Console.ReadLine().Split(' ').ToList();

            var phone = new Smartphone();
            phone.Call(numbers);
            phone.Browse(urls);
        }
    }
}
