using System;

namespace HW_04_task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = GetString();
            RemoveMaxWord(str);            
            ChangeStringMAXMIN(str);            
            ValueOfWord(str);
            SortOfArray(str);
        }
        static string GetString()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();           
            return input;
        }
        static void RemoveMaxWord(string str)
        {
            string[] strArray = str.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int maxLenght = 0, index = 0;
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length > maxLenght)
                {
                    maxLenght = strArray[i].Length;
                    index = i;
                }
            }
            Console.WriteLine("Самое длинное слово: {0}", strArray[index]);
            strArray[index] = default;            
            for (int i = 0; i < strArray.Length; i++)
            {
                if (i == strArray.Length -1)
                {
                    break;
                }
                 else if (i >= index)
                {
                    strArray[i] = strArray[i+1];                  
                }
            }
            Array.Resize(ref strArray, strArray.Length - 1);
            WriteArray(strArray);
        }
        static void ChangeStringMAXMIN(string str)
        {
            string[] strArray = str.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int maxLenght = 0, indexMax = 0;
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length > maxLenght)
                {
                    maxLenght = strArray[i].Length;
                    indexMax = i;
                }               
            }
            
            Console.WriteLine("Самое длинное слово: {0}", strArray[indexMax]);

            int minLenght = 100, indexMin = 0;
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length < minLenght)
                {
                    minLenght = strArray[i].Length;
                    indexMin = i;
                }
            }
            Console.WriteLine("Самое короткое слово: {0}", strArray[indexMin]);
            string temp = default;
            temp = strArray[indexMax];
            strArray[indexMax] = strArray[indexMin];
            strArray[indexMin] = temp;
            WriteArray(strArray);
        }
        static void ValueOfWord(string str)
        {
            string[] strArray = str.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int maxLenght = 0;
            for (int i = 0; i < strArray.Length; i++)
            {                                 
                maxLenght += strArray[i].Length; 
            }
            Console.WriteLine("Количество символов в строке: "+maxLenght);
        }
        static void WriteArray(string[] strArray)
        {
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.Write(strArray[i] + " ");
            }
            Console.WriteLine();
        }
        static void SortOfArray(string str)
        {
            string[] strArray = str.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string temp = default;
            for (int i = 0; i < strArray.Length-1; i++)
            {
                int smallestIndex = i;
                for (int curentIndex = i+1; curentIndex < strArray.Length; curentIndex++)
                {
                    if (strArray[curentIndex].Length < strArray[smallestIndex].Length)
                    {
                        smallestIndex = curentIndex;
                    }
                }
                temp = strArray[i];
                strArray[i] = strArray[smallestIndex];
                strArray[smallestIndex] = temp;
            }           
            WriteArray(strArray);
        }
    }
}
