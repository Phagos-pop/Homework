using System;

namespace HW_03_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = GetRandomArray();
            int[] inputArray = GetInputArray();
            int[] finalArray = SumOfArray(randomArray, inputArray);

            WriteArray(randomArray);
            WriteArray(inputArray);
            WriteArray(finalArray);
        }
        static int[] GetRandomArray()
        {
            Random rnd = new Random();
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1,10000);
            }

            return array;
        }
        static int[] GetInputArray()
        {
            int[] array = new int[10];
            bool test  = default;

            do
            {
                Console.WriteLine("Введите 10 чисел через пробел :");
                string[] str = Console.ReadLine().Trim().Split();
                
                for (int i = 0; i < str.Length; i++)
                {
                    try
                    {
                        array[i] = Convert.ToInt32(str[i]);
                        test = true;                        
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Вы ввели неправельное число или больше 10 чисел");
                        array = new int[10];
                        test = false;
                        break;
                    }
                }            
            } while (!test);

            return array;
        }
        static int[] SumOfArray(int[] firstArray,int[] secondArray)
        {
            int lenght;     
            
            if (firstArray.Length < secondArray.Length)
            {
                lenght = secondArray.Length;                
            }
            else
            {
                lenght = firstArray.Length;                
            }
            int[] finalArray = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                if (firstArray[i] != 0 && secondArray[i] != 0)
                {
                    finalArray[i] = firstArray[i] + secondArray[i];
                }                
                else if (firstArray[i] != 0 && secondArray[i] == 0)
                {
                    finalArray[i] = firstArray[i];
                }
                else if (firstArray[i] == 0 && secondArray[i] == 0)
                {
                    break;
                }
                
            }
            return finalArray;
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
 