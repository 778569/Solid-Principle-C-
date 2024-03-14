using Solid_Concept;

internal class Program
{
    private static void Main(string[] args)
    {
        IShape rectangle = new Rectangle();

        Shape shape = new Shape("4", rectangle,6,2);

        shape.CheckArea();

        Console.ReadLine();
    }
}