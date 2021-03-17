using System;

namespace Shape
{
    public class ShapeFactory
    {
        public static IShape GetShape(string shapeType, double[] args)
        {
            return shapeType switch
            {
                null => null,
                "Rectangle" when args.Length > 1 => new Rectangle(args[0], args[1]),
                "Square" when args.Length > 0 => new Square(args[0]),
                "Triangle" when args.Length > 2 => new Triangle(args[0], args[1], args[2]),
                _ => null
            };
        }
    }
}