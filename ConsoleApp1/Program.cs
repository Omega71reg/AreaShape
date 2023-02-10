// See https://aka.ms/new-console-template for more information
using AreaShape;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(new Circle(3).Area());
        Console.WriteLine(new Triangle(3,4,5).Area());
        Console.ReadKey();
        
    }
}