using System;

namespace NameAndAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello i am {name} and my age is {age}");
        }
    }
}
