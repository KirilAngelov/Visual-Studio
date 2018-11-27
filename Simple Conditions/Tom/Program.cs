using System;

namespace Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            int NoWorkDays = int.Parse(Console.ReadLine());
            int workDays = 365 - NoWorkDays;
            int playtime = NoWorkDays * 127 + workDays * 63;
            if (playtime>30000)
            {
                int dif = playtime - 30000;
                int hours = dif / 60;
                int minutes = dif - (hours * 60);
                Console.WriteLine("Tom will rum away");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
                
            }
            else
            {
                int dif = 30000 - playtime;
                int hours = dif / 60;
                int minutes = dif - (hours * 60);
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");

            }
        }
    }
}
