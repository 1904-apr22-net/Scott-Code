using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    public class NoisyCircle : BetterCircle
    {
        //override what the parent class does and put in alot of writeline to print out what is happening
        // by defualt you cannot override you can only add new properties 
        //we opt into the possinlitiy of overide in the parent class using the "virtual" modifier

        public double Radius
        {
            get
            {
                Console.WriteLine("Getting radius");
                return _radius;
            }
            set
            {
                Console.WriteLine("Setting radius");
                _radius = value;

            }
        }
        public override double GetPerimeter()
        {
            Console.WriteLine("getting perimeter.");
            return base.GetPerimeter();
        }
    }
}
