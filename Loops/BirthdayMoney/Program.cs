using System;

namespace BirthdayMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int timesForMoney = 0;
            double moneySum = 0.0;
            int toys = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i%2==0)
                {
                    timesForMoney++;
                    int moneyFromBday = 10 * timesForMoney;
                    moneySum += moneyFromBday;
                }
                else
                {
                    toys++;
                }
            }
            int moneyFromToys = toys * toyPrice;
            moneySum += moneyFromToys;
            moneySum-= (1 * timesForMoney);
           
            if (moneySum>price)
            {
                Console.WriteLine($"Yes!{String.Format("{0:0.00}", moneySum - price)}");
            }
            else
            {
                Console.WriteLine($"No!{String.Format("{0:0.00}", Math.Abs(moneySum - price))}");
            }
        }
    }
}
