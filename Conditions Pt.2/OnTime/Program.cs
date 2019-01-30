using System;

namespace OnTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int StartHour = int.Parse(Console.ReadLine());
            int StartMinutes = int.Parse(Console.ReadLine());
            int ArrivalHour = int.Parse(Console.ReadLine());
            int ArrivalMinutes = int.Parse(Console.ReadLine());
            if (StartHour == ArrivalHour)
            {
                if (StartMinutes < ArrivalMinutes)
                {
                    if (ArrivalMinutes - StartMinutes < 10)
                    {
                        Console.WriteLine($"Late with {ArrivalMinutes - StartMinutes}");
                    }
                    else { Console.WriteLine($"Late with {ArrivalMinutes - StartMinutes}"); }

                }
                if (StartMinutes > ArrivalMinutes)
                {
                    if (StartMinutes - ArrivalMinutes < 10)
                    {
                        Console.WriteLine($"Early with {StartMinutes - ArrivalMinutes}");
                    }
                    else
                    {
                        Console.WriteLine($"Early with {StartMinutes - ArrivalMinutes}");
                    }
                }
                if (StartMinutes == ArrivalMinutes)
                {
                    Console.WriteLine("On time");
                }
            }
            //14:50
            //13:20
            if (StartHour > ArrivalHour)
            {
                if (StartMinutes < ArrivalMinutes)
                {
                    Console.WriteLine($"Early with {60 + StartMinutes - ArrivalMinutes}");

                }
                if (StartMinutes > ArrivalMinutes)
                {
                    if (ArrivalMinutes - StartMinutes < 10)
                    {
                        Console.WriteLine($"Early with {StartHour - ArrivalHour}:{StartMinutes - ArrivalMinutes}");
                    }
                    else
                    {
                        Console.WriteLine($"On time {StartHour - ArrivalHour}:{StartMinutes - ArrivalMinutes}");
                    }
                }
                if (StartMinutes == ArrivalMinutes)
                {
                    Console.WriteLine($"Early with {StartHour - ArrivalHour}");
                }
            }
            if (StartHour < ArrivalHour)
            {
                if (StartMinutes < ArrivalMinutes)
                {
                    if (ArrivalMinutes - StartMinutes < 10)
                    {
                        Console.WriteLine($"Late with {ArrivalHour - StartHour}:0{ArrivalMinutes - StartMinutes}");
                    }
                    else
                    {
                        Console.WriteLine($"Late with {ArrivalHour - StartHour}:{ArrivalMinutes - StartMinutes}");
                    }

                }
                if (StartMinutes > ArrivalMinutes)
                {
                    Console.WriteLine($"Late with {60 + ArrivalMinutes - StartMinutes} minutes");
                }
                if (StartMinutes == ArrivalMinutes)
                {
                    Console.WriteLine($"Late with {ArrivalHour - StartHour} hours");
                }
            }
            
        }
    }
}
