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
            _pdfDocument = PdfDocument.Load(fileStream);
        }

        public override Image AsImage(int index)
        {
            return _pdfDocument.Render(index, 300, 300, true);
        }

        public override List<Image> AsImages()
        {
            List<Image> images = new List<Image>();
            for (int i = 0; i < _pdfDocument.PageCount; i++)
            {
                images.Add(_pdfDocument.Render(i, 300, 300, true));
            }
            return images;
        }
    }
}