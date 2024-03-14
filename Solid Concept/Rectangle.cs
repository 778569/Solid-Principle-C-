using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Concept
{
    public class Rectangle : IShape
    {
        public double CalculateArea(double height, double width)
        {
            new Logger().ConsoleLog("Calculating Area of Rectangle");
            
            Console.ReadLine();
            return height * width;

        }
    }
}
