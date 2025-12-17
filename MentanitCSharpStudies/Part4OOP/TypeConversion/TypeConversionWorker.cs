using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4OOP.TypeConversion
{
    internal static class TypeConversionWorker
    {
        public static void Run()
        {
            Circle circle = new Circle();
            Shape shape = (Shape)circle;
            List<Shape> shapes = new List<Shape> { new Circle(), new Square(), 
                new Square(), new Square(), new Circle()};

            ConverToCircle(shape);
            CircleHandler(shapes);
        }

        private static void ConverToCircle(Shape shape)
        {
            if(shape is Circle circle)
            {
                Console.WriteLine(circle.GetPerimeter(2));
            }
        }

        private static void CircleHandler(List<Shape> shapes)
        {
            foreach(Shape shape in shapes)
            {
                if(shape is Circle circle)
                {
                    Console.WriteLine(circle.GetPerimeter(3));                    
                }
            }
        }
    }
}
