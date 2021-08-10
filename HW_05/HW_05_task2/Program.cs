using System;
using System.Text;

namespace HW_05_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = GetStringBuilder();            
            RemoveSymbolBefore(ref str);
            ReplaceSymbolAfter(ref str);
            Console.WriteLine(str);
        }
        static StringBuilder GetStringBuilder()
        {
            Console.Write("Введите строку: ");
            StringBuilder input = new StringBuilder(Console.ReadLine());
            return input;
        }
        static void RemoveSymbolBefore(ref StringBuilder str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '?')
                {
                    break;
                }
                else if (str[i] == '!' || str[i] == '.')
                {                   
                    str.Remove(i,1);
                    i--;
                }                
            }
        }
        static void ReplaceSymbolAfter(ref StringBuilder str)
        {
            string strIndex = str.ToString();
            int indexOfQuestionMark = strIndex.IndexOf('?');
            str.Replace(' ', '_',indexOfQuestionMark,10);            
        }
    }
}
