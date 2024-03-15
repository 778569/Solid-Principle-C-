using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Concept
{
    public class Circle : ICirculeShape
    {
        private readonly ILogger logger;

        public Circle(ILogger logger)
        {
            this.logger = logger;
        }
        public double CalculateArea(double radius)
        {

            logger.Log("Calculating Area of Circle");
            return (22 / 7) * Math.Pow(radius, 2);
        }

    }
}
