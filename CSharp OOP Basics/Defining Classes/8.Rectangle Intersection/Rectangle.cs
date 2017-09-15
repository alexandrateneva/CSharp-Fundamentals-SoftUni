public class Rectangle
{
    public double X;
    public double Y;
    public double width;
    public double height;

    public Rectangle(double width, double height, double X, double Y)
    {
        this.width = width;
        this.height = height;
        this.X = X;
        this.Y = Y;
    }

    public string TheyIntersect(Rectangle secondRectangle)
    {

        if ((secondRectangle.Y >= this.Y && secondRectangle.Y - secondRectangle.height <= this.Y && secondRectangle.X <= this.X && secondRectangle.X + secondRectangle.width >= this.X) ||
            (secondRectangle.Y >= this.Y && secondRectangle.Y - secondRectangle.height <= this.Y && secondRectangle.X >= this.X && secondRectangle.X <= this.X + this.width) ||
            (secondRectangle.Y <= this.Y && secondRectangle.Y >= this.Y - this.height && secondRectangle.X <= this.X && secondRectangle.X + secondRectangle.width >= this.X) ||
            (secondRectangle.Y <= this.Y && secondRectangle.Y >= this.Y - this.height && secondRectangle.X >= this.X && secondRectangle.X <= this.X + this.width))
        {
            return "true";
        }
        return "false";
    }
}

