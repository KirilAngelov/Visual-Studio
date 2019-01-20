using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (true)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("Even");
                    break;
                }
                else
                {
                    Console.WriteLine("Enter again");
                    n = int.Parse(Console.ReadLine());


                }

            }
       
          
          
          
        }
    }
}
