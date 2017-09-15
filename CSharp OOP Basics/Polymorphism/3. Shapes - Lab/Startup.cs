namespace _3.Shapes___Lab
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Circle circle = new Circle(5);
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.Draw());
        }
    }
}
