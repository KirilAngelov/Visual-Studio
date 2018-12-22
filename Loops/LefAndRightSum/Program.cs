using System;

namespace LefAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rigthSum = 0;
            for (int i = 0; i < 2*n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i<n)
                {
                    leftSum = leftSum + num;
                }
                else
                {
                    rigthSum = rigthSum + num;
                }
            }
            if (leftSum==rigthSum)
            {
                Console.WriteLine($"Yes,sum = {leftSum}");
            }
            else
            {
                int diff = Math.Abs(leftSum - rigthSum);
                Console.WriteLine($"No,diff = {diff}");
            }
        }
    }
}
