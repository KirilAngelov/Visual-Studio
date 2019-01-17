using System;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = n - 2;
            for (int i = 1; i <=n-2; i++)
            {
                if (i%2==0)
                {
                    Console.Write(new string('-',stars));
                    Console.Write("\\");
                    Console.Write(" ");
                    Console.Write("/");
                    Console.Write(new string('-', stars));
                    Console.WriteLine();


                }
                else
                {
                    Console.Write(new string('*', stars));
                    Console.Write("\\");
                    Console.Write(" ");
                    Console.Write("/");
                    Console.Write(new string('*', stars));
                    Console.WriteLine();
                }
            }
            Console.Write(new string(' ', n - 1));
            Console.Write("@");
            Console.WriteLine();
            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(new string('-', stars));
                    Console.Write("/");
                    Console.Write(" ");
                    Console.Write("\\");
                    Console.Write(new string('-', stars));
                    Console.WriteLine();


                }
                else
                {
                    Console.Write(new string('*', stars));
                    Console.Write("/");
                    Console.Write(" ");
                    Console.Write("\\");
                    Console.Write(new string('*', stars));
                    Console.WriteLine();
                }
            }
        }
        
    }
}
