using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Biggest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i <n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }
            int biggest = numbers.Max();
            int lowest = numbers.Min();
            Console.WriteLine();
            Console.WriteLine(biggest);
            Console.WriteLine(lowest);
        }
    }
}
