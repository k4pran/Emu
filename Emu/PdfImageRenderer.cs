using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using PdfiumViewer;

namespace Emu
{
    public class PdfImageRenderer : ImageRenderer
    {
        private PdfDocument _pdfDocument;
        
        public PdfImageRenderer(string filePath) : base(filePath)
        {
        }
        
        protected override void Read(FileStream fileStream)
        {
            PdfDocument pdfDocument = PdfDocument.Load(fileStream);
            Image img = pdfDocument.Render(2, 300, 300, true);
            new Bitmap(img).Save("C:/Users/ryan/RiderProjects/Emu/Emu.Tests/Resources/output/test2.png", ImageFormat.Png);
        }

        public override Image AsImage(int index)
        {
            throw new NotImplementedException();
        }

        public override List<Image> AsImages()
        {
            throw new NotImplementedException();
        }
    }
}