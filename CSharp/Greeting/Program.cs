using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine($"Hello i am {name} amd my age is {age}. I am from {town}.");
        }
    }
}
