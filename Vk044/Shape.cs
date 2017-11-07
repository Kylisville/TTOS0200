using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vko44
{
    abstract class Shape
    {
        public string Name { get; set; }

     
        public abstract double Circumference();

        public abstract double Area();
        
    }

     class Rectangle : Shape
    {
        double X { get; set; }
        double Y { get; set; }
        public Rectangle(double x, double y)
        {
           
            X = x;
            Y = y;
        }
        public override double Circumference()
        {
            return 2 * (X + Y);
           
        }
        public override double Area()
        {
            return X * Y;
        }
        public override string ToString()
        {
            return "Rectangle Width = " + X + " Height = " + Y + " Area = " + Area() + " Circumference = " + Circumference();
        }
    }
    class Circle : Shape
    {
        double Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return 3.14 * (2 * Radius);
        }
        public override double Circumference()
        {
            return 2 * 3.14 * Radius;
        }
        public override string ToString()
        {
            return "Circle Radius = " + Radius + " Area = " + Area() + " Circumference = " + Circumference();
        }
    }
}
