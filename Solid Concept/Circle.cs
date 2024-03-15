using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Concept
{
    public class Circle : ICirculeShape
    {
        public double CalculateArea(double radius)
        {

            new Logger().ConsoleLog("Calculating Area of Circle");
            return (22 / 7) * Math.Pow(radius, 2);
        }

    }
}
