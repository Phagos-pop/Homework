using System;

namespace HW_05_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstStringArray = { "arp", "er" , "live", "strong" , "tion" };
            string[] secondStringArray = { "lively", "alive", "harp", "sharp", "armstrong" , "nation"};
            string[] finalStingArray = GetFinalStringArray(firstStringArray, secondStringArray);
            WriteArray(finalStingArray);
        }
        static string[] GetFinalStringArray(string[] firstStringArray,string[] secondStringArray)
        {
            string[] finalStringArray = new string[10];
            for (int i = 0; i < firstStringArray.Length; i++)
            {
                for (int j = 0; j < secondStringArray.Length; j++)
                {
                    if (secondStringArray[j].Contains(firstStringArray[i]))
                    {
                        finalStringArray[i] = firstStringArray[i];
                    }                    
                }
            }
            return finalStringArray;
        }
        static void WriteArray(string[] array)
        {
            Console.Write("Получившийся масив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
