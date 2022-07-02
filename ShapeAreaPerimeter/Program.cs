using System;

namespace ShapeAreaPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.WriteLine("The area of the circle is "+circle.area());
            Console.WriteLine("The circumference of the circle is " + circle.perimeter());

            Rectangle rec = new Rectangle(8, 9);
            Console.WriteLine("The area of the rectangle is " + rec.area());
            Console.WriteLine("The perimeter of the rectangle is " + rec.perimeter());
        }
    }
    public interface IShape //Shape interface
    {
        double area();
        double perimeter();
    }
    
    public class Circle : IShape //Circle class
    {
        public double radius=12;
        const double PI = 3.14;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle() {}
        public double area()
        {
            double area = PI * (radius * radius);
            return area;
        }
        public double perimeter()
        {
            double cicumference = 2 * (PI * radius);
            return cicumference;
        }
    }
    public class Rectangle :IShape //Rectangle class
    {
        public double length=5;
        public double width=6;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public Rectangle() {}

        public double area()
        {
            double area = length * width;
            return area;
        }
        public double perimeter()
        {
            double perimeter = 2 * (length+width);
             return perimeter;
        }
    }
}
