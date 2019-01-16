using System;

namespace Advanced_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            //only odd 
            int n = int.Parse(Console.ReadLine());
            int[] arrOdd = new int[n - 1];
            arrOdd[0] = 0;
            
            for (int i = 1; i <=n-2 ; i++)
            {
                arrOdd[i] = (i * 2) - 1;
            }
           
            
            if (n%2!=0)
            {
                if (n == 3)
                {
                    Console.Write('-');
                    Console.Write('*');
                    Console.Write('-');
                    Console.WriteLine();
                    Console.Write('*');
                    Console.Write('-');
                    Console.Write('*');
                    Console.WriteLine();
                    Console.Write('-');
                    Console.Write('*');
                    Console.Write('-');
                    Console.WriteLine();
                }

                else
                {
                    for (int i = 0; i < n - 2; i++)
                    {
                        Console.Write(new string('-', n - 3 - i));
                        Console.Write("*");
                        Console.Write(new string('-', arrOdd[i]));
                        if (i >= 1)
                        {
                            Console.Write("*");
                        }

                        Console.Write(new string('-', n - 3 - i));
                        Console.WriteLine();
                    }
                    for (int k = 1; k <= n - 4; k++)
                    {
                        Console.Write(new string('-', k));
                        Console.Write("*");
                        Console.Write(new string('-', arrOdd[n - 3 - k]));
                        Console.Write("*");
                        Console.Write(new string('-', k));
                        Console.WriteLine();
                    }
                    for (int i = 0; i < 1; i++)
                    {
                        Console.Write(new string('-', n - 3));
                        Console.Write("*");
                        Console.Write(new string('-', n - 3));
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
