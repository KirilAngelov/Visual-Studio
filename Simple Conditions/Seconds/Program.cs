using System;

namespace Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int sum = first + second + third;
            if (sum<60)
            {
                Console.WriteLine($"0:{sum}");
            }
            if (sum>=60 && sum<120)
            {
                if (sum-60<10)
                {
                    Console.WriteLine($"1:0{sum-60}");
                }
                else
                {
                    Console.WriteLine($"1:{sum-60}");
                }
            }
            if(sum>120)
            {
                if (sum-120<10)
                {
                    Console.WriteLine($"2:0{sum-120}");
                }
                else
                {
                    Console.WriteLine($"2:{sum-120}");
                }
            }

        }
    }
}
