using System;

namespace Exam4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int levasFromOneBitcoin = 1168;
            const double levasFromOneEuro = 1.94;
            int bitcoins = int.Parse(Console.ReadLine());
            double yans = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());
            double levaFromBitcoins = (bitcoins * levasFromOneBitcoin);
            Console.WriteLine(levaFromBitcoins);
            double levasFromOneYan = ((yans * 0.15)*1.76);
            Console.WriteLine(levasFromOneYan);
            double euroFromLevas = (levasFromOneYan + levaFromBitcoins)/1.95;
            double sumCom = (euroFromLevas * commision) / 100;
            Console.WriteLine(euroFromLevas-sumCom);

           
            

        }
    }
}
