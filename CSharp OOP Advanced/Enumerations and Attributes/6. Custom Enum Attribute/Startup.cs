namespace _6.Custom_Enum_Attribute
{
    using System;
    using _6.Custom_Enum_Attribute.Attributes;
    using _6.Custom_Enum_Attribute.Enums;

    public class Startup
    {
        public static void Main()
        {
            var enumType = Console.ReadLine();
            Type type;
            if (enumType == "Rank")
            {
                type = typeof(Rank);
            }
            else
            {
                type = typeof(Suit);
            }
            var allAttributes = type.GetCustomAttributes(false);
            foreach (TypeAttribute attribute in allAttributes)
            {
                Console.WriteLine($"Type = {attribute.Type}, Description = {attribute.Description}");
            }
        }
    }
}
