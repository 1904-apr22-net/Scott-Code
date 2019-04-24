using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library.Interfaces
{
    //in an interface all members must share access of the whole interface always public
    //interface is a garunetee of what a class has to follow 
    public interface IShape
    {
        double GetPerimeter();
        double Area { get; }

        int Sides { get; }
    }
}
