using System;
using System.IO;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            StreamReader textReader = new StreamReader(@"C:\Users\Phagos\Desktop\image.txt", true);
            string textReaderResult = textReader.ReadToEnd();
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }

            File.WriteAllBytes(@"C:\Users\Phagos\Desktop\image.png", imageBytes);
            textReader.Dispose();
        }
    }
}
