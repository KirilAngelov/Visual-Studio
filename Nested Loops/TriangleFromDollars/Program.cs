using System;

namespace TriangleFromDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("$");
                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write(" $");

                }
                Console.WriteLine();
            }
        }
    }
}
