using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ASCII_Art
{
    class Program
    {
        static void Main(string[] args)

        { 
            //Done! Will try to clean up code and document everything.
            Bitmap image = new Bitmap("C:\\Users\\spard\\Desktop\\Apple.jpg");
            Image image1 = new Bitmap("C:\\Users\\spard\\Desktop\\Apple.jpg");
            Bitmap imageResized = ResizeImage(image1, 60, 60);
            imageResized.RotateFlip(RotateFlipType.Rotate90FlipX);
            int height = imageResized.Height;
            int width = imageResized.Width;
            char[] characters = "`^\",:;Il!i~+_-?][}{1)(|\\/tfjrxnuvczXYUJCLQ0OZmwqpdbkhao*#MW&8%B@$".ToArray();
            int[,] pixelMatrix = new int[height + 1, width + 1];
            int[,] brightnessMatrix = new int[height + 1, width + 1];
            char[,] asciiMatrix = new char[height + 1, width + 1];

            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < width; k++)
                {
                    Color pixel = imageResized.GetPixel(i, k);

                    int sum = GetSumOfPixels(pixel);
                    pixelMatrix[i, k] = sum;
                    brightnessMatrix[i, k] = sum / 3;


                }
            }
            Console.WriteLine();
            //For characters maping maybe try to devide brightnessMatrix index by 4
            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < width; k++)
                {
                    Color pixel = imageResized.GetPixel(i, k);

                    int sum = GetSumOfPixels(pixel) / 3;
                    asciiMatrix[i, k] = characters[sum / 4];
                }
            }
            PrintAsciiArt(height, width, asciiMatrix);


        }
        //This method prints the final ASCII matrix
        public static void PrintAsciiArt(int height, int width, char[,] asciiMatrix)
        {
            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < width; k++)
                {
                    if (k == width - 1)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(asciiMatrix[i, k]);
                    }

                }
            }
        }
        //This method gets the sum of each RGB value of the pixel so that we can map it to characters
        public static int GetSumOfPixels(Color pixel)
        {
            int redNumber = pixel.R;
            int GreenNumber = pixel.G;
            int BlueNumber = pixel.B;
            int sum = redNumber + BlueNumber + GreenNumber;
            return sum;
        }
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
