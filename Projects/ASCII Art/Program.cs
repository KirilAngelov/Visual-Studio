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
            int[,] pixelMatrix = new int [width+1,height+1];
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
                    
                }
            }
            //Test if everything is working and then continue with brightness matrix
            for (int i = 0; i < width; i++)
            {
                for (int k = 0; k < height; k++)
                {
                    Console.WriteLine(pixelMatrix[i,k]);
                }
            }
            /*int offset = y * image.Width * 3 + x * 3; rgbBytes[offset + 0] = pixel.R;
            rgbBytes[offset + 1] = pixel.G; rgbBytes[offset + 2] = pixel.B;
            */
        }
    }
}
