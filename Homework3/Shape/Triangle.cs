using System;

namespace Shape
{
    public class Triangle : IShape
    {
        public double A { set; get; }
        public double B { set; get; }
        public double C { set; get; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            Console.WriteLine($"Generated a triangle with A {A} and B {B} and C {C}");

        }
        public double GetArea()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public bool IsValid()
        {
            return A > 0 && B > 0 && C > 0 && A + B > C && A + C > B && B + C > A;
        }
    }
}