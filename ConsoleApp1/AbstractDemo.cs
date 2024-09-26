using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    abstract class Shape
    {
        public abstract double CalculateArea();

        public virtual void Display()
        {
            Console.WriteLine("This is a shape.");
        }

    }

    class Rectangle : Shape
    {
        private double _length;
        private double _width;

        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }
        public override double CalculateArea()
        {
            return _length * _width;
        }
        public override void Display()
        {
            Console.WriteLine($"This is a rectangle with length {_length} and width {_width}.");
        }
    }
    class Circle : Shape
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
        public override void Display()
        {
            Console.WriteLine($"This is a circle with radius {_radius}.");
        }
    }
    internal class AbstractDemo
    {
        static void Main()
        {

            Shape rectangle = new Rectangle(4.5, 3.7);
            rectangle.Display();
            Console.WriteLine($"Area: {rectangle.CalculateArea()}");


            Shape circle = new Circle(5.5);
            circle.Display();
            Console.WriteLine($"Area: {circle.CalculateArea()}");
        }
    }
}
