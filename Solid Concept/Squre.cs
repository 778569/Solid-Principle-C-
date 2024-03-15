using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Concept
{
    public class Squre : IAngularShape
    {
        public double CalculateArea(double height, double width)
        {

            new Logger().ConsoleLog("Calculating Area of Squre");
            return height * width;
        }

        
    }
}
