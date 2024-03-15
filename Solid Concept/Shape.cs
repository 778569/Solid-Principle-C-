using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Concept
{
    public class Shape
    {
        private readonly IAngularShape shape;
        private readonly ICirculeShape circuleShape;

        public string NameOfShape { get; set; }

        public int height { get; set; }

        public int width { get; set; }
        public int radius { get; set; }

        public Shape(string nameOfShape, IAngularShape shape, int height, int width, ICirculeShape circuleShape)
        {
            this.NameOfShape = nameOfShape;
            this.shape = shape;
            this.height = height;
            this.width = width;
            this.circuleShape = circuleShape;
        }

        public Shape(int radius)
        {
            this.radius = radius;
        }

        public void CheckArea()
        {
            var area =  shape.CalculateArea(height, width);

            Console.WriteLine(area);
        }

        public void CheckAreaCircle()
        {
            var area = circuleShape.CalculateArea(radius);

            Console.WriteLine(area);
        }






        //public double CalculateArea(double height, double width)
        //{
        //    switch (NameOfShape)
        //    {
        //        case "Squre":
        //            //Console.WriteLine("Calculating Area of Square");
        //            new Logger().ConsoleLog("Calculating Area of Square");
        //            return width * height;
        //        case "Rectangle":
        //            //Console.WriteLine("Calculating Area of Rectangle");
        //            new Logger().ConsoleLog("Calculating Area of Rectangle");

        //            return width * height;
        //        default:
        //            return 0;
        //    }
        //}



    }
}
