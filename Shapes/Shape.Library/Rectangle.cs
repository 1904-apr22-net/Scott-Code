using System;
using System.Collections.Generic;
using System.Text;
using Shapes.Library.Interfaces;

namespace Shapes.Library
{
    public class Rectangle : IShape
    {
        public double Length { get; set; }
        //in both VS and VS code, because we write properties so often we can type " prop<tab><tab>

        public double Width { get; set; }
        public int Sides => 4;
        public double GetPerimeter()
        {
            return 2 * Length + 2 * Width;
        }
        public double Area
        {
            get
            {
                return Length * Width;
            }
        }
       // public double Area => Length* Width
       //above is another way to write the area getter method "=>" gets a value that cannont be set 
       //public double Area {get
      
    }
}
