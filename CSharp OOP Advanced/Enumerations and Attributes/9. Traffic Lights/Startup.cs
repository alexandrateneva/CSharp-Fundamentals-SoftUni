namespace _9.Traffic_Lights
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var allLights = Console.ReadLine()
                .Split(' ')
                .Select(l => Enum.Parse(typeof(Light), l))
                .ToList();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < allLights.Count; j++)
                {
                    var lastLight = (Light)allLights[j];
                    var nextLight = GetNextLight(lastLight);
                    allLights[j] = nextLight;
                }
                Console.WriteLine(string.Join(" ", allLights));
            }
        }

        public static Light GetNextLight(Light lastLight)
        {
            var lights = Enum.GetValues(typeof(Light)).OfType<Light>().ToList();
            var index = lights.IndexOf(lastLight);

            if (index + 1 < lights.Count)
            {
                return lights[index + 1];
            }
            return lights[0];
        }
    }
}
