using System;

namespace HW_03_task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 122; i > 64; i--)
            {
                if (i >= 91 && i <= 96)
                {
                    continue;
                }
                char word = (char)i;
                Console.Write($"{word} ");
                counter++;
                if (counter % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
