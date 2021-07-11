using System;
using System.Diagnostics;

namespace HW_04_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = GetRandomArray();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            ReversArray(ref array);
            stopwatch.Stop();
            Console.WriteLine("Собственный метод " + stopwatch.ElapsedMilliseconds);

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            Array.Reverse(array);
            stopwatch1.Stop();
            Console.WriteLine("Системный метод " + stopwatch1.ElapsedMilliseconds);
        }
        static long[] GetRandomArray()
        {
            Random rnd = new Random();
            long[] array = new long[100_000_000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next();
            }
            return array;
        }
        static void ReversArray(ref long[] array)
        {
            long temp = 0;         
            for (int i = 0; i < array.Length/2; i++)
            {
                if (true)
                {
                    temp = array[i];
                    array[i] = array[array.Length - i - 1];
                    array[array.Length - i - 1] = temp;
                }
            }
        }        
    }
}
