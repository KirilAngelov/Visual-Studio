using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type=="square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine(side*side);
            }
            if (type == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine(sideA* sideB);
            }
            if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
               
                Console.WriteLine(radius*Math.PI);
            }
            if (type == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine((side * height)/2);
            }


        }
    }
}
