using System;

namespace Number_To_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] firstDigits = new string [] { "zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine","ten","eleven","twelve","thirteen","forteen","fifteen","sixteen","seventeen,","eighteen","nineteen" };
            string[] bigDigits = new string[] {"bla" ,"bla", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            if (number/10<2)
            {
                foreach (var item in firstDigits)
                {
                    if (item.Equals(firstDigits[number]))
                    {
                        Console.WriteLine(firstDigits[number]);
                    }
                }
            }
            if (number/10>=2)
            {
                int firstDigit = number / 10;
                int secondDigit = number % 10;
                foreach (var item in bigDigits)
                {
                    if (item.Equals(bigDigits[firstDigit]))
                    {
                        Console.Write(bigDigits[firstDigit]+" ");
                    }
                }
                if (secondDigit==0)
                {
                    Console.WriteLine();
                    return;
                }
                foreach (var item in firstDigits)
                {
                    if (item.Equals(firstDigits[secondDigit]))
                    {
                        Console.Write(firstDigits[secondDigit]);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
