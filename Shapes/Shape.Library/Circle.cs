using System;

namespace Shapes.Library
{
    //defualt access for class is internal
    public class Circle
    {
        private double radius;

        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            if (radius < 0)
            {
                System.Console.WriteLine("not allowwed!");
            }
            else
            {
                this.radius = radius;
            }

        }
    }
}
