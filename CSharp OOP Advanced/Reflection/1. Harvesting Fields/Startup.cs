namespace _1.Harvesting_Fields
{
    using System;
    using System.Linq;
    using System.Reflection;
    using _1.Harvesting_Fields.Models;

    public class Startup
    {
        public static void Main()
        {
            var typeOfClass = typeof(RichSoilLand);
            FieldInfo[] allFields = typeOfClass.GetFields(BindingFlags.Instance | BindingFlags.Static |
                                                          BindingFlags.Public | BindingFlags.NonPublic);
            FieldInfo[] nonPublicFields = typeOfClass.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo[] publicFields = typeOfClass.GetFields(BindingFlags.Instance | BindingFlags.Public);
            var privateFields = nonPublicFields.Where(f => f.IsPrivate).ToArray();
            var protectedFields = nonPublicFields.Where(f => f.IsFamily).ToArray();


            var input = Console.ReadLine();
            while (input != "HARVEST")
            {
                switch (input)
                {
                    case "private": PrintAll(privateFields); break;
                    case "protected": PrintAll(protectedFields); break;
                    case "public": PrintAll(publicFields); break;
                    case "all": PrintAll(allFields); break;
                }

                input = Console.ReadLine();
            }
        }

        public static void PrintAll(FieldInfo[] fields)
        {
            foreach (var field in fields)
            {
                var accessModifier = field.Attributes.ToString().ToLower();
                if (accessModifier == "family")
                {
                    accessModifier = "protected";
                }
                Console.WriteLine($"{accessModifier} {field.FieldType.Name} {field.Name}");
            }
        }
    }
}
