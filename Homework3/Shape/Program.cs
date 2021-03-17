using System;
using System.Collections.Generic;

namespace Shape
{
    internal class Program
    {
        private static void Main()
        {
            double totalArea = 0;
            for (var i = 1; i <= 10; i++)
            {
                var randomShapeNum = new Random().Next(0, 3);
                var randomShape = randomShapeNum switch
                {
                    0 => "Rectangle",
                    1 => "Square",
                    2 => "Triangle",
                    _ => null
                };
                double[] sides = { new Random().NextDouble() * 10, new Random().NextDouble() * 10, new Random().NextDouble() * 10};
                var shape = ShapeFactory.GetShape(randomShape, sides);
                if (shape != null && shape.IsValid())
                    totalArea += shape.GetArea();
            }
            Console.WriteLine($"Total area is {totalArea}");
        }
    }
}
