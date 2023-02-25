using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Emu
{
    public class PngWriter : IImageWriter
    {
        public void WriteImage(Image image, string location)
        {
            string targetDir = Path.GetDirectoryName(location);
            if (!Directory.Exists(targetDir))
            {
                Console.Write("Invalid directory " + targetDir);
            }
            new Bitmap(image).Save(location, ImageFormat.Png);
        }
    }
}