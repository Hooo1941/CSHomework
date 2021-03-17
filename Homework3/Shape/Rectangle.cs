using System;

namespace Shape
{
    public class Rectangle : IShape
    {
        public double Width { set; get; }
        public double Height { set; get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
            Console.WriteLine($"Generated a rectangle with width {Width} and height {height}");
        }
        public double GetArea()
        {
            return Width * Height;
        }
        public bool IsValid()
        {
            return Width > 0 && Height > 0;
        }
    }
}