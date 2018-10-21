using System;

namespace Exam5
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            double levaFromOneDollar = double.Parse(Console.ReadLine());
            double moneyFromOneYear = (days * money) * 12 + (days * money) * 2.5;
          
            double taxes = ((moneyFromOneYear * 25) / 100);
            double realMoney = moneyFromOneYear - taxes;

            double levaFromMoney = realMoney * levaFromOneDollar;
            double levaEveryDay = levaFromMoney / 365;
            Console.WriteLine(String.Format("{0:0.00}", levaEveryDay));
        }
    }
}
