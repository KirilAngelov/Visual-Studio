using System;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            int ivanAge = 18;
            double heritage = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            for (int i = 1800; i <= year; i++)
            {
                if (i%2==0)
                {
                    
                    heritage -= 12000;
                }
                else
                {

                    heritage -= 12000 + ivanAge * 50;
                    
                }
                ivanAge++;
            }
            if (heritage>0)
            {
                Console.WriteLine($"Yes,he will live a good life and have {String.Format("{0:0.00}",heritage)} dollars left");
            }
            else
            {
                Console.WriteLine($"No,he will need { String.Format("{0:0.00}", Math.Abs(heritage))} dollars to survive");
            }
        }
    }
}
