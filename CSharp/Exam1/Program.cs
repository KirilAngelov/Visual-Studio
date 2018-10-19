using System;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {   const double rowHeight= 1.2;
            const double coridorWidth = 1.0;
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            int rows = (int)(height / rowHeight);
            double realWidth = width - coridorWidth;
            int desksOnRow = (int)(realWidth / 0.7);
            Console.WriteLine(rows*desksOnRow-3);

        }
    }
}
