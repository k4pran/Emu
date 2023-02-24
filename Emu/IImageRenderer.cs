using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Emu
{
    public interface IImageRenderer
    {
        Image AsImage(int index);

        List<Image> AsImages();
    }
}