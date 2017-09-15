namespace _14.Drawing_tool
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var command = Console.ReadLine();

            if (command == "Square")
            {
                var size = int.Parse(Console.ReadLine());
                var square = new Square(size);
                square.Draw();
            }
            else if (command == "Rectangle")
            {
                var width = int.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());
                var rectangle = new Rectangle(width, height);
                rectangle.Draw();
            }
        }
    }
}
