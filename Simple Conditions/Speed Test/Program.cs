using System;

namespace Speed_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number<10)
            {
                Console.WriteLine("slow");
            }
            else if (number<50)
            {
                Console.WriteLine("average");
            }
            else if (number<150)
            {
                Console.WriteLine("fast");
            }
            else if (number<=1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
            {

            }
        }
    }
}
