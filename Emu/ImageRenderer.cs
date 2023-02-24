using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Emu
{
    public abstract class ImageRenderer : IImageRenderer
    {
        protected ImageRenderer(string filePath)
        {
            this.Read(filePath);
        }

        protected abstract void Read(FileStream fileStream);
        public abstract Image AsImage(int index);
        public abstract List<Image> AsImages();

        private void Read(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found at " + filePath);
            }
            Read(File.OpenRead(filePath));
        }
    }
}