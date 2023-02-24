using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Emu
{
    public class TxtImageRenderer : ImageRenderer
    {
        public TxtImageRenderer(string filePath) : base(filePath)
        {
        }

        protected override void Read(FileStream fileStream)
        {
            throw new System.NotImplementedException();
        }

        public override Image AsImage(int index)
        {
            throw new System.NotImplementedException();
        }

        public override List<Image> AsImages()
        {
            throw new System.NotImplementedException();
        }
    }
}