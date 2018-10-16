using System;

namespace Coordinate_System_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double rectangleSideA = Math.Abs(x1 - x2);
            double rectangleSideB = Math.Abs(y1 - y2);
            double surface = rectangleSideA * rectangleSideB;
            double area = rectangleSideA * 2 + rectangleSideB * 2;
            Console.WriteLine(surface);
            Console.WriteLine(area);
           
           

        }
    }
}
