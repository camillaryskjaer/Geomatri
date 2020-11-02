using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomatriOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(3);
            // calculates tr Perimeter of a Square
            Console.WriteLine($"The Perimeter of the square is: {square.CalcPerimeter()} something");
            Console.WriteLine($"The Areal of the square is: {square.CalcAreal()} something");
            Parallelogram parallelogram = new Parallelogram(3, 5, 20);
            Console.WriteLine($"The Perimeter of the parallelogram is: {parallelogram.CalcPerimeter()} something");
            Console.WriteLine($"The Areal of the parallelogram is: {parallelogram.CalcAreal()} something");
            Trapez trapez = new Trapez(10, 9, 8, 9);
            Console.WriteLine($"The Perimeter of the parallelogram is: {trapez.CalcPerimeter()} something");
            Console.WriteLine($"The Areal of the Trapez is: {trapez.CalcAreal()} something");
            Triangle triangle = new Triangle(4, 5, 6);
            Console.WriteLine($"The Perimeter of the Triangle is: {triangle.CalcPerimeter()} something");
            Console.WriteLine($"The Areal of the Triangle is: {triangle.CalcAreal()} something");

            Console.WriteLine();

            List<Shape> shapes = new List<Shape>();
            shapes.Add(square);
            shapes.Add(parallelogram);
            shapes.Add(trapez);
            shapes.Add(triangle);

            foreach (var shape in shapes)
            {

                Console.WriteLine($"{shape.CalcPerimeter()}");
                Console.WriteLine($"{shape.CalcAreal()}");
            }

            Console.ReadLine();
        }
    }
}