using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 800, 11, 50, 771, 649, 770, 240, 9 };
            int length = array.Length;

            int temp = array[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];

                        array[i] = array[j];

                        array[j] = temp;
                    }
                }
               
            }

        }
    }
}
