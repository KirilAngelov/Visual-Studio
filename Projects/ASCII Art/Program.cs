using System;
using System.Collections;
using System.Collections.Generic;
using ImageMagick;
using System.Drawing;
namespace ASCII_Art
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            MagickImageInfo info = new MagickImageInfo("C:\\Users\\spard\\Desktop\\ascii-pineapple.jpg");
            int width = info.Width;
            int height = info.Height;
            Console.WriteLine(width);
            Console.WriteLine(height);
            ColorRGB[,] pixel_Matrix = new ColorRGB[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int k = 0; k < height; k++)
                {
                   
                    Pixel pixel= new Pixel(i, k, 4);
                    pixel_Matrix[i, k] = pixel.ToColor();


                }
            }
            
            Console.Write(pixel_Matrix[100,300]);





        }
    }
}
