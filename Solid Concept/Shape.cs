using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Concept
{
    public class Shape : IShape
    {
        public string NameOfShape { get; set; }

        public Shape(string nameOfShape)
        {
            this.NameOfShape = nameOfShape;
        }

        public double CalculateArea(double height, double width)
        {
            switch (NameOfShape)
            {
                case "Squre":
                    Console.WriteLine("Calculating Area of Square");
                    return width * height;
                case "Rectangle":
                    Console.WriteLine("Calculating Area of Rectangle");
                    return width * height;
                default:
                    return 0;
            }
        }
    }
}
