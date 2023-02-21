using System;
using System.IO;
using NUnit.Framework;

namespace Emu.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            PdfReader pdfReader = new PdfReader();
            string baseDir = Environment.CurrentDirectory;
            string projectDir = Directory.GetParent(baseDir).Parent.Parent.FullName;
            FileStream fileStream = File.OpenRead(Path.Combine(projectDir, "Resources", "dracula.pdf"));
            pdfReader.Read(fileStream);
            Assert.Pass();
        }
    }
}