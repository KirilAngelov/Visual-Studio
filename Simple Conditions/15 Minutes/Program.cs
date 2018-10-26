using System;

namespace _15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            //23:46-00:01
            //8:45-09:00
            //8:44-8:59
            if (minutes+15<60)
            {
                Console.WriteLine($"{hours}:{minutes+15}");
            }
            else if (minutes + 15 == 60 && hours != 23)
            {
                Console.WriteLine($"{hours + 1}:00");
            }
            else if (minutes + 15 - 60 < 10 && hours != 23)
            {
                Console.WriteLine($"{hours + 1}:0{minutes + 15 - 60}");

            }
            else if (minutes + 15 - 60 > 10 && hours != 23)
            {
                Console.WriteLine($"{hours + 1}:{minutes + 15 - 60}");
            }
            else if (hours == 23 && minutes + 15 == 60)
            {
                Console.WriteLine("00:00");
            }
            else if (hours == 23 && minutes + 15 - 60 < 10)
            {
                Console.WriteLine($"00:0{minutes+15-60}");
            }
            else if (hours==23&&minutes+15-60>10)
            {
                Console.WriteLine($"00:{minutes + 15 - 60}");
            }

          



        }
    }
}
