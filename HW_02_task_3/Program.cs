using System;

namespace HW_02_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Явные преобразования 
            decimal a1 = 123;

            long a2 = (long)a1;

            int a3 = (int)a2;

            short a4 = (short)a3;

            byte a5 = (byte)a4;
            // Неявные преобразования
            short b1 = a5;

            int b2 = b1;

            long b3 = b2;

            decimal b4 = b3;

            float number = 123;
            double b5 = number;
            // Упаковка
            string s1 = "pop";
            object c1 = s1;

            int s2 = 123;
            object c2 = s2;

            char s3 = 'p';
            object c3 = s3;

            double s4 = 10.2;
            object c4 = s4;

            byte[] array = new byte[2] { 1, 2 };
            object[] array2 = new object[2];
            for (int i = 0; i < 1; i++)
            {
                array2[i] = array[i];
            }
            //Распаковка
            string p1 = (string)c1;

            int p2 = (int)c2;

            char p3 = (char)c3;

            double p4 = (double)c4;

            byte[] array3 = new byte[2];
            for (int i = 0; i < 1; i++)
            {
                array3[i] = (byte)array2[i];
            }
        }
    }
}
