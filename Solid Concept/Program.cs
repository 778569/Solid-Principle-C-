using Solid_Concept;

internal class Program
{
    private static void Main(string[] args)
    {
        //IShape squre = new Squre();

        //Shape shape = new Shape("4", squre, 6,6);

        //shape.CheckArea();

        ICirculeShape circuleShape = new Circle();

        var CircleArea  = circuleShape.CalculateArea(6);

        Console.WriteLine(CircleArea);

        Console.ReadLine();
    }
}