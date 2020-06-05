using CoreBackpack.Images;
using System;
using System.IO;

namespace CMYKToRGBForWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            string imageToConvert = @"C:\xfer\ImageTest\butterflies-png-26541.png";
            string output = @"C:\xfer\ImageTest\out2.jpg";

            FileStream fs = new FileStream(imageToConvert, FileMode.Open);

            var convert = new ImageConvert();
            var newStream = convert.Execute(fs, 800, 800);

            fs.Close();

            WriteTheFile(output, newStream);

            Console.WriteLine("Completed!");
        }

        private static void WriteTheFile(string fileName, MemoryStream memStream)
        {
            FileStream fs2 = new FileStream(fileName, FileMode.CreateNew);

            var array = memStream.ToArray();
            fs2.Write(array, 0, array.Length);
            fs2.Close();
        }
    }
}
