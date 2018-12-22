using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            decimal studioRent = 0;
            decimal apartamentRent = 0;
            if (month=="May" || month=="October")
            {
                decimal studioForOneNight = 50;
                decimal apartamentForOneNight = 65;
                if (nights >= 7&& nights<14)
                {
                    studioForOneNight = studioForOneNight - ((studioForOneNight * 5) / 100);
                }
                if (nights >= 14)
                {
                    studioForOneNight = studioForOneNight - ((studioForOneNight * 30) / 100);
                    apartamentForOneNight = apartamentForOneNight - ((apartamentForOneNight * 10) / 100);
                }
                studioRent =nights * studioForOneNight;
                apartamentRent = nights * apartamentForOneNight;
               
            }
            else if (month=="June"||month=="September")
            {
                decimal studioForOneNight = 75.20m;
                decimal apartamentForOneNight = 68.70m;
                if (nights>14)
                {
                    studioForOneNight = studioForOneNight - ((studioForOneNight * 20) / 100);
                    apartamentForOneNight = apartamentForOneNight - ((apartamentForOneNight * 10) / 100);
                }
                studioRent = nights * studioForOneNight;
                apartamentRent = nights * apartamentForOneNight;
            }
            else
            {
                decimal studioForOneNight = 76m;
                decimal apartamentForOneNight = 77m;
                if (nights>14)
                {
                    apartamentForOneNight = apartamentForOneNight - ((apartamentForOneNight * 10) / 100);
                }
                studioRent = nights * studioForOneNight;
                apartamentRent = nights * apartamentForOneNight;
            }

            Console.WriteLine($"Apartament: {String.Format("{0:0.00}", apartamentRent)} lv");
            Console.WriteLine($"Studio: {String.Format("{0:0.00}",studioRent)} lv");
        }
    }
}
