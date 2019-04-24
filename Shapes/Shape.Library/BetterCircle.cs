using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    public class BetterCircle
    {
        protected double _radius;
        

        public double X { get; set; }
        public double Y { get; set; }

        public virtual double Radius
            //"virtual": 

        {
            get
            {
                return _radius * 1.01;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("error");

                }
                else
                {
                    _radius = value;

                }
            }
        }
        public virtual double GetPerimeter() => 2 * Math.PI * Radius;

        public double Area => Math.PI * Radius * Radius;
    }
}
