using System;

namespace EvenAndOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            int sum =0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals('a'))
                {
                    sum += 1;
                }
                if (text[i].Equals('e'))
                {
                    sum += 2;

                }
                if (text[i].Equals('i'))
                {
                    sum += 3;
                }
                if (text[i].Equals('o'))
                {
                    sum += 4;
                }
                if (text[i].Equals('u'))
                {
                    sum += 5;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
