using System;

namespace Doctors
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int unthreaded = 0;
            int threaded = 0;
            int doctors = 7;
            int nepreglefani = 0;
            for (int i = 1; i <= period; i++)
            {
                int patientsForADay = int.Parse(Console.ReadLine());
                if (i > 1 && i % 3 == 0)
                {
                    if (nepreglefani > threaded)
                    {
                        doctors++;
                    }
                }
                if (patientsForADay <= doctors)
                {
                    threaded += patientsForADay;
                }
                else
                {
                    unthreaded = (patientsForADay - doctors);
                    int patient = patientsForADay - unthreaded;
                    threaded += patient;
                    nepreglefani += unthreaded;
                }

            }
            Console.WriteLine($"Threaded patients: {threaded}");
            Console.WriteLine($"Unthreaded patients: {nepreglefani}");
        }
    }
}
