using System;
using System.Linq;
namespace _1000_Days_On_Earth
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
            DateTime date = new DateTime(info[2],info[1],info[0]);
            Console.WriteLine(date.AddDays(999).ToString("dd-MM-yyyy"));
            
           
            
        }
    }
}
