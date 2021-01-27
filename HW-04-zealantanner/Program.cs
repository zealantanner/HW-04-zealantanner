using System;

namespace CS1405_Lab
{
    public class Shape : object
    {
        public int Xcord { get; set; }
        public int Ycord { get; set; }

        public int GetXcord()
        {
            return Xcord;
        }
        public int GetYcord()
        {
            return Ycord;
        }
    }
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public int GetHeight()
        {
            return Height;
        }
        public int GetWidth()
        {
            return Width;
        }
    }
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public int GetRadius()
        {
            return Radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Shape();
            shape1.Xcord = 1;
            shape1.Ycord = 1;
            Console.WriteLine($"shape1");
            Console.WriteLine($"X cord: {shape1.GetXcord()}");
            Console.WriteLine($"Y cord: {shape1.GetYcord()}");

            Rectangle rectangle1 = new Rectangle();
            rectangle1.Xcord = 2;
            rectangle1.Ycord = 3;
            rectangle1.Height = 5;
            rectangle1.Width = 6;
            Console.WriteLine($"rectangle1");
            Console.WriteLine($"X cord: {rectangle1.GetXcord()}");
            Console.WriteLine($"Y cord: {rectangle1.GetYcord()}");
            Console.WriteLine($"Height: {rectangle1.GetHeight()}");
            Console.WriteLine($"Width: {rectangle1.GetWidth()}");

            Circle circle1 = new Circle();
            circle1.Xcord = 2;
            circle1.Ycord = 3;
            circle1.Radius = 5;
            Console.WriteLine($"circle1");
            Console.WriteLine($"X cord: {circle1.GetXcord()}");
            Console.WriteLine($"Y cord: {circle1.GetYcord()}");
            Console.WriteLine($"Radius: {circle1.GetRadius()}");
        }
    }
}
