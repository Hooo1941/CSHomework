using System;

namespace Shape
{
    public class ShapeFactory
    {
        public static IShape GetShape(string shapeType, double[] arg)
        {
            return shapeType switch
            {
                null => null,
                "Rectangle" when arg.Length > 1 => new Rectangle(arg[0], arg[1]),
                "Square" when arg.Length > 0 => new Square(arg[0]),
                "Triangle" when arg.Length > 2 => new Triangle(arg[0], arg[1], arg[2]),
                _ => null
            };
        }
    }
}