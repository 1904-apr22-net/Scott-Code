using Shapes.Library;
using System;

namespace Shapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle();

            double r = cir.GetRadius();

            cir.SetRadius(-4);

            BetterCircle better = new BetterCircle();

            better.Radius = 5;
            Console.WriteLine(better.Radius);


            Console.WriteLine("Hello World!");
        }
        static void ShapeWork()
        {
            Rectangle r = new Rectangle();

            r.Length = 4;
            r.Width = 3;

            Console.WriteLine(r.GetPerimeter());
            Console.WriteLine(r.Area);

            BetterCircle circle = new BetterCircle();
            circle.Radius = 8;

            PrintShapeDetails(r);
        }
        static void PrintShapeDetails(IShape shape, string name)
        {
            Console.WriteLine("Shape" + name);
            
        }
        BetterCircle bluecircle = new NoisyCircle();
    }
}
