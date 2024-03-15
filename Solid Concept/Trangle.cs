using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Concept
{
    public class Trangle : IAngularShape
    {
        public double CalculateArea(double height, double width)
        {

            new Logger().ConsoleLog("Calculating Area of Trangle");
            return (height * width)/2;
        }

       
    }
}
