using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ASCII_Art
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap image = new Bitmap("C:\\Users\\spard\\Desktop\\ascii-pineapple.jpg");
            
           
            int height = image.Height;
            int width = image.Width;
            Console.WriteLine(height);
            Console.WriteLine(width);
           char[] characters = "`^\",:;Il!i~+_-?][}{1)(|\\/tfjrxnuvczXYUJCLQ0OZmwqpdbkhao*#MW&8%B@$".ToArray();
            int[,] pixelMatrix = new int [width+1,height+1];
            int[,] brightnessMatrix = new int[width + 1, height + 1];
            for (int i = 0; i < width; i++)
            {
                for (int k = 0; k < height; k++)
                {
                    Color pixel = image.GetPixel(i,k);
                  
                    int redNumber = pixel.R;
                    int GreenNumber = pixel.G;
                    int BlueNumber = pixel.B;
                    int sum = redNumber + BlueNumber + GreenNumber;
                    pixelMatrix[i, k] = sum;
                    brightnessMatrix[i, k] = sum / 3;
                    
                }
            }
            Console.WriteLine();
            //For characters maping maybe try to devide brightnessMatrix index by 4
            for (int i = 0; i < width; i++)
             {
                 for (int k = 0; k < height; k++)
                 {
                     //Console.WriteLine(pixelMatrix[i,k]);
                     Console.WriteLine(brightnessMatrix[i,k]);
                 }
             }
            
           
        }
    }
}
