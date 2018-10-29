using System;
using System.Linq;
namespace Cvukov
{
    class Program
    {
        static void Main(string[] args)
        {

            int first = 1;
            int second = 1;
            Console.WriteLine(first);
            Console.WriteLine(second);
            int third = 0;
            int[] arr = new int[18];
            int[] arrCopy = new int[18];
            for (int i = 2; i < 20; i++)
            { 
                third = first + second;
                arr[i - 2] = third;
                arrCopy[i - 2] = third;
                first = second;
                second = third;

            }
            double[] occurencies = new double[10];
            occurencies[1]++;
            occurencies[1]++;
            for (int i = 0; i < arr.Length; i++)
            {
                int nums = arr[i].ToString().Length;
                for (int j = 0; j < nums; j++)
                {
                    int num = arr[i] % 10;
                    arr[i] = arr[i] / 10;
                    occurencies[num]++;
                }
                Console.WriteLine(arrCopy[i]);
            }
            Console.WriteLine(new string('-',15));
            //for (int i = 0; i < occurencies.Length; i++)
            //{
            //    Console.WriteLine($"{i}-{occurencies[i]} times");
            //}
            double answer = occurencies.Max();
            int index = Array.IndexOf(occurencies, answer);
            Console.WriteLine($"Most frequent number is {index} and it occured {answer} times");
        }
    }
}
