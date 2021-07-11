using System;

namespace HW_04_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = GetInputArray();            
            StickNumberToArray(array);
            WriteArray(array);
        }
        static int[] GetInputArray()
        {
            int[] array = new int[10];
            bool test = default;

            do
            {
                Console.WriteLine("Введите 9 чисел через пробел :");
                string[] str = Console.ReadLine().Trim().Split();

                for (int i = 0; i < 9; i++)
                {
                    try
                    {
                        array[i] = Convert.ToInt32(str[i]);
                        test = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Вы ввели неправельное число");
                        array = new int[10];
                        test = false;
                        break;
                    }
                }
            } while (!test);

            return array;
        }
        static void StickNumberToArray(int[] array)
        {
            Console.WriteLine("Введите число которое вы хотите вставить в массив: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите индекс(от 1 до 9): ");
            int index = Convert.ToInt32(Console.ReadLine());
            index--;
            int temp = 0;
            int temp2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    temp = array[i];
                    array[i] = number;                  
                }
                else if (i > index)
                {
                    temp2 = array[i];
                    array[i] = temp;
                    temp = temp2;
                }
            }
        }
        static void WriteArray(int[] finalArray)
        {
            for (int i = 0; i < finalArray.Length; i++)
            {
                Console.Write(finalArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
