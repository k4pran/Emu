using System.IO;

namespace Emu
{
    public abstract class Reader : IReader
    { 
        public abstract void Read(FileStream fileStream);

        public void Read(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found at " + filePath);
            }
            Read(File.OpenRead(filePath));
        }
    }
}