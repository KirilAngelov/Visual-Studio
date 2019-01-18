using System;

namespace This_Way_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            //3->1  3/2=1
            //5->2  5/2=2
            //9->4  9/2=4
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('.', n / 2));
            Console.Write(new string('*', n));
            Console.Write(new string('.', n / 2));
            Console.WriteLine();
            for (int i = 0; i < n-2; i++)
            {
                Console.Write(new string('.',n/2));
                Console.Write("*");
                Console.Write(new string('.', n-2));
                Console.Write('*');
                Console.Write(new string('.', n / 2));
                Console.WriteLine();
            }
            //3->2  5->3  9->4
            Console.Write(new string('*',(n/2)+1));
            Console.Write(new string('.',n-2));
            Console.Write(new string('*', (n / 2) + 1));
            Console.WriteLine();
            int[] arr = new int[n - 1];
            arr[0] = 0;
            arr[1] = 2 * n - 5;
            for (int i = 2; i <= n - 2; i++)
            {
                arr[i] = arr[i - 1] - 2;
            }

            for (int i = 1; i <= n-2; i++)
            {
                Console.Write(new string('.',i));
                Console.Write("*");
                Console.Write(new string('.',arr[i]));
                Console.Write("*");
                Console.Write(new string('.', i));
                Console.WriteLine();
            }
            Console.Write(new string('.',n-1));
            Console.Write("*");
            Console.Write(new string('.', n - 1));
            Console.WriteLine();
        }
    }
}
