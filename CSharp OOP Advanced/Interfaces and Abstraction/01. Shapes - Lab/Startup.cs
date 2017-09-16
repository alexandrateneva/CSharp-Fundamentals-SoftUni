namespace _01.Shapes___Lab
{
    using System;
    using _01.Shapes___Lab.Interfaces;
    using _01.Shapes___Lab.Models;

    public class Startup
    {
        public static void Main()
        {
            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);

            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(width, height);

            circle.Draw();
            rect.Draw();
        }
    }
}
