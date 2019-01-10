using System;

namespace SquareFromStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n+1; i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.Write("*");
                    for (int j = 0; j < n-1; j++)
                    {
                        Console.Write(" *");
                    }
                    Console.WriteLine();
                  

                }
                

            }
        }
    }
}
