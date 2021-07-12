using System;

namespace HW_04_task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стихотворение в одну строку разделяя строки точкой с запятой: ");
            string[] str = Console.ReadLine().Trim().Split(';');

            for (int i = 0; i < str.Length; i++)
            {
                string text = str[i];
                str[i] = text.Replace("о","а");                
                Console.WriteLine(str[i]);
            }
        }
    }
}
//Нарисую солнышко; У себя в альбоме; И как будто станет; Посветлее в доме.