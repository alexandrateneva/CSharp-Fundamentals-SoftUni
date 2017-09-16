namespace _01.Shapes___Lab.Models
{
    using System;
    using _01.Shapes___Lab.Interfaces;

    public class Rectangle : IDrawable
    {
        public int Height { get; private set; }
        public int Width { get; private set; }

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public void Draw()
        {
            this.DrawLine(this.Width, '*', '*');
            for (int i = 1; i < this.Height - 1; ++i)
            {
                this.DrawLine(this.Width, '*', ' ');
            }
            this.DrawLine(this.Width, '*', '*');
        }

        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; ++i)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }

    }
}
