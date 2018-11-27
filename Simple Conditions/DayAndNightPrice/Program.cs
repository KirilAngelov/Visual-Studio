using System;

namespace DayAndNightPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            String dayOrNight = Console.ReadLine();
            double price = 0;
            if (dayOrNight == "day")
            {
                if (distance<20)
                {
                    price = (0.79 * distance)+0.7;
                }
                if (distance>=20 && distance<100)
                {
                    price = 0.09 * distance;
                }
                else if (distance>=100)
                {
                    price = 0.06 * distance;
                }
            }
            if(dayOrNight=="night")
            {
                if (distance < 20)
                {
                    price = (0.90 * distance)+0.7;
                }
                else if (distance >= 20 && distance<100)
                {
                    price = 0.09 * distance;
                }
                else if (distance >= 100)
                {
                    price = 0.06 * distance;
                }
            }
            Console.WriteLine(price);
        }
    }
}
