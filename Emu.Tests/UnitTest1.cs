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
            string baseDir = Environment.CurrentDirectory;
            string projectDir = Directory.GetParent(baseDir).Parent.Parent.FullName;
            new PdfImageRenderer(projectDir);
            Assert.Pass();
        }
    }
}