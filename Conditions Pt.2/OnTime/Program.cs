using System;

namespace OnTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHour=int.Parse(Console.ReadLine());
            int startMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());
            if (startHour==arrivalHour)
            {
                if (startMinutes<arrivalMinute)
                {
                    if (arrivalMinute - startMinutes < 10)
                    {
                        Console.WriteLine($"Early with {arrivalMinute - startMinutes}");
                    }
                    else { Console.WriteLine($"Early with {arrivalMinute - startMinutes}"); }
                   
                }
                if (startMinutes>arrivalMinute)
                {
                    if (startMinutes-arrivalMinute < 10)
                    {
                        Console.WriteLine($"Late with {startMinutes-arrivalMinute}");
                    }
                    else
                    {
                        Console.WriteLine($"Late with {startMinutes - arrivalMinute}");
                    }
                }
                if (startMinutes==arrivalMinute)
                {
                    Console.WriteLine("On time");
                }
            }
            //14:50
            //13:20
            if (startHour>arrivalHour)
            {
                if (startMinutes<arrivalMinute)
                {
                     Console.WriteLine($"On time {60 + startMinutes - arrivalMinute}");
                   
                }
                if (startMinutes>arrivalMinute)
                {
                    if (arrivalMinute - startMinutes < 10)
                    {
                        Console.WriteLine($"On time {startHour - arrivalHour}:0{startMinutes - arrivalMinute}");
                    }
                    else
                    {
                        Console.WriteLine($"On time {startHour - arrivalHour}:{startMinutes - arrivalMinute}");
                    }
                }
                if (startMinutes==arrivalMinute)
                {
                    Console.WriteLine($"On time {startHour-arrivalHour}");
                }
            }
            if (startHour<arrivalHour)
            {
                if (startMinutes<arrivalMinute)
                {
                    if (arrivalMinute - startMinutes<10)
                    {
                        Console.WriteLine($"Late with {arrivalHour - startHour}:0{arrivalMinute - startMinutes}");
                    }
                    else
                    {
                        Console.WriteLine($"Late with {arrivalHour - startHour}:{arrivalMinute - startMinutes}");
                    }
                   
                }
                if (startMinutes>arrivalMinute)
                {
                    Console.WriteLine($"Late with {60+arrivalMinute-startMinutes} minutes");
                }
                if (startMinutes==arrivalMinute)
                {
                    Console.WriteLine($"Late with {arrivalHour-startHour} hours");
                }
            }
        }
    }
}
