namespace _7.Fix_Emails
{
    using System;
    using System.Collections.Generic;

    public class FixEmails
    {
        public static void Main()
        {
            var name = Console.ReadLine();

            var emailbook = new Dictionary<string, string>();

            while (name != "stop")
            {
                var email = Console.ReadLine();
                var mailEnd = email.Substring(email.Length - 2, 2).ToLower();

                if (mailEnd != "uk" && mailEnd != "us")
                {
                    emailbook.Add(name, email);
                }
                name = Console.ReadLine();
            }
            foreach (var person in emailbook)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }
    }
}
