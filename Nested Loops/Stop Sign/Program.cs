using System;

namespace Stop_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n= int.Parse(Console.ReadLine());
            //Testing and planning
            //1-5=2*n-1 n=3      1-11=2*n-1 n=6    
            //2-7=2*n+1 n=3      2-13=2*n+1 n=6     
            //3-9=2*n+3 n=3      3-15=2*n+3 n=6
            int[] arr = new int[n+2];
            int[] arr2 = new int[100];
            arr2[0] = 0;
            arr2[1] = -1;
            for (int i = 2; i < arr2.Length; i++)
            {
                arr2[i] = (2 * i) - 3;
                //2->1 2*i-3 i=2
                //3->3 2*i-3 i=3
                //4->5 2*i-3 i=4
            }
            arr[0] = 0;
            for (int i = 1; i <= n+1; i++)
            {
                arr[i] = (2 * n) + arr2[i];
            }
            Console.Write(new string('.',n+1));
            Console.Write(new string('_',(2*n)+1));
            Console.Write(new string('.', n + 1));
            Console.WriteLine();
            for (int i = 0; i <n ; i++)
            {
                Console.Write(new string('.',n-i));
                Console.Write("//");
                Console.Write(new string('_',arr[i+1]));
                Console.Write("\\\\");
                Console.Write(new string('.', n - i));
                Console.WriteLine();
            }

            int spaces = arr[arr.Length - 1];
            int spacesBeforeStop = (spaces - 5) / 2;
            Console.Write("//");
            Console.Write(new string('_',spacesBeforeStop));
            Console.Write("STOP!");
            Console.Write(new string('_', spacesBeforeStop));
            Console.Write("\\\\");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.',i));
                Console.Write("\\\\");
                Console.Write(new string('_',(arr[arr.Length-1-i])));
                Console.Write("//");
                Console.Write(new string('.', i));
                Console.WriteLine();
            }


        }
    }
}
