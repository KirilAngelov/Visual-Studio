using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace EvenAndOddHard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            List<int> pairsSum = new List<int>();
            for (int i = 0; i < 2*n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);

            }
            if (n%2==0)
            {
                for (int i = 2; i <= numbers.Capacity; i = i + 2)
                {
                    int sum = numbers[i - 2] + numbers[i - 1];
                    pairsSum.Add(sum);
                }
            }
            else
            {
                for (int i = 2; i < numbers.Capacity; i = i + 2)
                {
                    int sum = numbers[i - 2] + numbers[i - 1];
                    pairsSum.Add(sum);
                }
            }
            
            List<int> distinctList = pairsSum.Distinct().ToList();
            int max = distinctList.Max();
            List<int>list=distinctList.OrderBy(x => x > 0).Reverse().ToList();
           
            if (distinctList.Count!=1)
            {
                Console.WriteLine($"No, maxdiff = {max-list.Last()}");
            }
            else
            {
                Console.WriteLine($"Yes, value = {max}");
            }

        }
    }
}
