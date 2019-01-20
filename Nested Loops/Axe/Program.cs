using System;

namespace Axe
{
    class Program
    {
        private const int V = 1;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('-',3*n));
            Console.Write("**");
            Console.Write(new string('-',(5*n-3*n-2)));
            Console.WriteLine();
            for (int i = 1; i <= n-1; i++)
            {
                Console.Write(new string('-', 3 * n));
                Console.Write("*");
                Console.Write(new string('-',i));
                Console.Write("*");
                Console.Write(new string('-',(5*n)-3*n-2-i));
                Console.WriteLine();
            }
            for (int i = 1; i <= n/2; i++)
            {
                Console.Write(new string('*',n*3));
                Console.Write('*');
                Console.Write(new string('-',n-1));
                Console.Write("*");
                Console.Write(new string('-',n-1));
                Console.WriteLine();
            }
            int[] arr = new int[n/2];
            int[] arr2 = new int[n / 2];
            arr[0] = n - 1;
            arr2[0] = n - 1;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + 2;
                arr2[i] = arr2[i - 1] - 1;
            }

            if (n==2)
            {
                Console.Write(new string('-',3*2));
                Console.Write(new string('*',3));
                Console.Write('-');
            }
            else
            {
                for (int i = 0; i <= ((n / 2) - 1) - 1; i++)
                {
                    Console.Write(new string('-', 3 * n - i));
                    Console.Write('*');
                    Console.Write(new string('-', arr[i]));
                    Console.Write('*');
                    Console.Write(new string('-', arr2[i]));
                    Console.WriteLine();
                    if (i == ((n / 2) - 1) - 1)
                    {
                        Console.Write(new string('-', (3 * n) - (n / 2) + 1));

                        Console.Write(new string('*', 5 * n - ((3 * n) - (n / 2)) - (arr2[i] - 1) - 1));
                        Console.Write(new string('-', (arr2[i] - 1)));

                    }

                }
            }
           
           
           
        }
    }
}
