﻿public class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }
    
    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    public override double CalculatePerimeter()
    {
        return this.height * 2 + this.width * 2;
    }

    public override double CalculateArea()
    {
        return this.height * this.width;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}
