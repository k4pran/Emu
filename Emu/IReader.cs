using System.IO;

namespace Emu
{
    public interface IReader
    {
        void Read(FileStream fileStream);
    }
}