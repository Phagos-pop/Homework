using System;
using System.IO;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // streamReader для чтения файла и записи его содержимово в переменную textReader 
            StreamReader textReader = new StreamReader(@"C:\Users\Phagos\Desktop\image.txt", true);
            // создает переменную типа string и записывает в нее все из переменной textReader
            string textReaderResult = textReader.ReadToEnd();
            // создает массив arrayOfTextResult и записывает в него все значения из textReader; .Split существует для разделения и стирания пробелов
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            // создает масив для байтов, длиной массива arrayOfTextResult
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
            // цикл конвертирует string массив в byte массив
            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }
            // создает файл с получившейся фотографией
            File.WriteAllBytes(@"C:\Users\Phagos\Desktop\image.png", imageBytes);
            // освобождает память занятую переменной textReader
            textReader.Dispose();
        }
    }
}
