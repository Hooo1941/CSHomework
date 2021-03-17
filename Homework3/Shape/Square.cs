using System;

namespace Shape
{
    public class Square : Rectangle
    {
        public Square(double side) : base(side, side)
        {
            Console.WriteLine($"Generated a square with side {side}");

        }
    }
}