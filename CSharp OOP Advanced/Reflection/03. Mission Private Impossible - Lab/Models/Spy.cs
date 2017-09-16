namespace _03.Mission_Private_Impossible___Lab.Models
{
    using System;
    using System.Reflection;
    using System.Text;

    public class Spy
    {
        public string RevealPrivateMethods(string investigatedClass)
        {
            Type classType = Type.GetType(investigatedClass);
            MethodInfo[] classMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"All Private Methods of Class: {investigatedClass}");
            stringBuilder.AppendLine($"Base Class: {classType.BaseType.Name}");

            foreach (var method in classMethods)
            {
                stringBuilder.AppendLine($"{method.Name}");
            }

            return stringBuilder.ToString().Trim();
        }
    }
}