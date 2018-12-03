using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            int rows = int.Parse((Console.ReadLine()));
            int columns=int.Parse(Console.ReadLine());
            if (s=="Premiere")
            {
                double price = 12.00;
                Console.WriteLine(String.Format("{0:0.00}", rows * columns * price));
            }
            if (s=="Normal")
            {
                double price = 7.50;
               
                Console.WriteLine(String.Format("{0:0.00}", rows * columns * price));
            }
            if (s=="Discount")
            {
                int price =5;
                Console.WriteLine(String.Format("{0:0.00}", rows * columns * price));

            }
        }
    }
}
