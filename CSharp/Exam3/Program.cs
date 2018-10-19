using System;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double tileTime = 0.2;
            int playgroundSide = int.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileLenght = double.Parse(Console.ReadLine());
            double benchWidth = double.Parse(Console.ReadLine());
            double benchLenght = double.Parse(Console.ReadLine());
            double benchSurface = benchLenght * benchWidth;
            double playGroudSurface = (playgroundSide * playgroundSide)-benchSurface;
            double tileSurface = tileLenght * tileWidth;
            double tilesNumber = (playGroudSurface / tileSurface);
            double time = tilesNumber * tileTime;
            Console.WriteLine(tilesNumber);
            Console.WriteLine(time);

          
        }
    }
}
