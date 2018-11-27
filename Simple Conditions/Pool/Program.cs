using System;

namespace Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volumeOfPool = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double litresOfp1 = hours * p1;
            double litresOfp2 = hours * p2;
            double sum = litresOfp1 + litresOfp2;
            string percentOfp1= String.Format("{0:0}", (litresOfp1 * 100) / sum)+"%";
            string percentOfp2 = String.Format("{0:0}", (litresOfp2 * 100) / sum) + "%";
            string percentOfsum = String.Format("{0:0}", (sum * 100) / volumeOfPool) + "%";
            if (volumeOfPool>sum)
            {
                Console.WriteLine($"The pool is {percentOfsum} full");
                Console.WriteLine($"Pipe 1:{percentOfp1}");
                Console.WriteLine($"Pipe 2:{percentOfp2}");
            }
            else
            {
                double overflow = sum - volumeOfPool;
                Console.WriteLine($"For {hours} the pool overflows with {overflow} litres");
            }


        }
    }
}
