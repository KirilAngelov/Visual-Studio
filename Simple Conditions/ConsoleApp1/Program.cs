using System;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double bonus = 0.0;
            if (number%2==0)
            {
                bonus += 1;
                if (number<100)
                {
                    bonus += 5;
                }
                else if (number>100 && number<1000)
                {
                    bonus += (number * 20) / 100;

                }
                else
                {
                    bonus += (number * 10) / 100;
                }
            }
            else
            {
                bonus += 2;
                if (number < 100)
                {
                    bonus += 5;
                }
                else if (number > 100 && number < 1000)
                {
                    bonus += (number * 20) / 100;

                }
                else
                {
                    bonus += (number * 10) / 100;
                }
            }
            Console.WriteLine(bonus);
            Console.WriteLine(number+bonus);
        }
    }
}
