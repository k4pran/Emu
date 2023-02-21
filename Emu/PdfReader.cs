using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using PdfiumViewer;

namespace Emu
{
    public class PdfReader : Reader
    {
        public override void Read(FileStream fileStream)
        {
            PdfDocument pdfDocument = PdfDocument.Load(fileStream);
            Image img = pdfDocument.Render(2, 300, 300, true);
            new Bitmap(img).Save("C:/Users/ryan/RiderProjects/Emu/Emu.Tests/Resources/output/test2.png", ImageFormat.Png);
        }
    }
}