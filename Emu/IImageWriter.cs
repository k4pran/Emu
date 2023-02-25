using System.Drawing;

namespace Emu
{
    public interface IImageWriter
    {
        void WriteImage(Image image, string location);
    }
}