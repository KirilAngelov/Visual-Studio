using System;

namespace Home
{
    class Program
    {
        static void Main(string[] args)

        
        {
            //only odd numbers
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n - 1];
            arr[0] = 0;
            for (int i = 1; i <= n-2; i++)
            {
                arr[i] = (i * 2) - 1;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            for (int i = 1; i <= n-3; i++)
            {

                for (int j = 0; j < n-2-i; j++)
                {
                    Console.Write("-");
                  
                }
                for (int k = 0; k < 1; k++)
                {
                    Console.Write(new string('*',arr[i]));
                }
                for (int j = 0; j < n - 2 - i; j++)
                {
                    Console.Write("-");

                }
                Console.WriteLine();
                

            }
            Console.Write(new string('*', arr[n - 2]));
            Console.WriteLine();
            int spaces = (n / 2) - 2;
            for (int i = 0; i < n-3; i++)
            {
                
                Console.Write(new string(' ',spaces));
                Console.Write("|");
                Console.Write(new string('*',n-2));
                Console.Write("|");
                Console.WriteLine();
            }
           
        }
    }
}
