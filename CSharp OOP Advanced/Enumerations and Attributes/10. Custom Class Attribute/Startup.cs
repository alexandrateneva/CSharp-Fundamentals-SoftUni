namespace _10.Custom_Class_Attribute
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var type = typeof(Weapon);
            var allAttributes = type.GetCustomAttributes(false);

            foreach (CustomAttribute attribute in allAttributes)
            {
                var command = Console.ReadLine();
                while (command != "END")
                {
                    switch (command)
                    {
                        case "Author":
                            Console.WriteLine($"Author: {attribute.Author}");
                            break;
                        case "Revision":
                            Console.WriteLine($"Revision: {attribute.Revision}");
                            break;
                        case "Description":
                            Console.WriteLine($"Class description: {attribute.Description}");
                            break;
                        case "Reviewers":
                            Console.WriteLine($"Reviewers: {string.Join(", ", attribute.Reviewers)}");
                            break;
                    }

                    command = Console.ReadLine();
                }
            }
        }
    }
}
