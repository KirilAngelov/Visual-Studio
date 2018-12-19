using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            bool rectangleOneOut = (x > 3 * h || y > h);
            bool rectangleTwoOut = ((x < h && y > h) || (x > 2 * h && y > h));
            bool rectangleOneIn = (x < 3 * h && y < h);
            bool rectangleTwoIn = ((x > h && x < 2 * h) && (y > h && y < 4 * h));
            if (rectangleOneOut && rectangleTwoOut)
            {
                Console.WriteLine("Out");
            }
            else if (rectangleOneIn ||rectangleTwoIn)
            {
                Console.WriteLine("In");
            }
            else
            {
                Console.WriteLine("Border");
            }

        }
    }
}
