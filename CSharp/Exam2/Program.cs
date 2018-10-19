using System;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablesKgPrice = double.Parse(Console.ReadLine());
            double fruitsKgPrice = double.Parse(Console.ReadLine());
            int vegetablesWeight = int.Parse(Console.ReadLine());
            int fruitsWeight = int.Parse(Console.ReadLine());
            double vegetablesPrice = vegetablesKgPrice * vegetablesWeight;
            double fruitsPrice = fruitsKgPrice * fruitsWeight;
            double sum = vegetablesPrice + fruitsPrice;
            Console.WriteLine(sum/1.94);

        }
    }
}
