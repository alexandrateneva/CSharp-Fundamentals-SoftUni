namespace _2.Black_Box_Integer
{
    using System;
    using System.Linq;
    using System.Reflection;
    using _2.Black_Box_Integer.Models;

    public class Startup
    {
        public static void Main()
        {
            var constructors = typeof(BlackBoxInt).GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic);
            var constructor = constructors.First(c => c.GetParameters().FirstOrDefault().Name == "innerValue");
            var obj = constructor.Invoke(new object[] { 0 });
            var methods = typeof(BlackBoxInt).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic |
                                                         BindingFlags.DeclaredOnly);

            var input = Console.ReadLine();
            while (input != "END")
            {
                var commandArgs = input.Split('_');
                var command = commandArgs[0];
                var value = int.Parse(commandArgs[1]);
                var currentMethod = methods.First(m => m.Name == command);
                currentMethod.Invoke(obj, new object[] { value });

                var fieldToPrint = typeof(BlackBoxInt).GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                    .FirstOrDefault(p => p.Name == "innerValue");
                var innerValue = fieldToPrint.GetValue(obj);
                Console.WriteLine(innerValue);

                input = Console.ReadLine();
            }
        }
    }
}
