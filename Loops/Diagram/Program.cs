using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace Diagram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int Bellow200 = 0;
            int Between200And399 = 0;
            int Between400And599 = 0;
            int Betweem600And799 = 0;
           int OverOrEqual800 = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number<200)
                {
                    Bellow200++;
                }
                else if (number>=200 && number<=399)
                {
                    Between200And399++;
                }
                else if (number>=400 && number<=599)
                {
                    Between400And599++;
                }
                else if (number>=600 && number <=799)
                {
                    Betweem600And799++;
                }
                else
                {
                    OverOrEqual800++;
                }
            }
            
            decimal p1 = ((Bellow200 / (decimal)n)) * 100;
           String resultP1= String.Format("{0:0.00}%", p1);
            decimal p2 = ((Between200And399 / (decimal)n)) * 100;
            String resultP2  = String.Format("{0:0.00}%", p2);
            decimal p3 = ((Between400And599 / (decimal)n)) * 100;
            String resultP3 = String.Format("{0:0.00}%", p3);
            decimal p4 = ((Betweem600And799 / (decimal)n)) * 100;
            String resultP4 = String.Format("{0:0.00}%", p4);
            decimal p5 = ((OverOrEqual800 / (decimal)n)) * 100;
            String resultP5 = String.Format("{0:0.00}%", p5);
            Console.WriteLine(resultP1);
            Console.WriteLine(resultP2);
            Console.WriteLine(resultP3);
            Console.WriteLine(resultP4);
            Console.WriteLine(resultP5);
        }
    }
}
