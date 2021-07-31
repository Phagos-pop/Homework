using System;
using System.Text.RegularExpressions;

namespace HW_05_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = GetString();
            GetNumberFromString(str, out int firstNumber, out int secondNumber);
            GetSymbolFromString(str, out char symbol);
            MathOperation(firstNumber,secondNumber,symbol);
        }
        static string GetString()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            return input;
        }
        static void GetNumberFromString(string str,out int firstNumber, out int secondNumber)
        {
            string[] strArray = str.Split(new char[] {'*','/','-','+'});

            firstNumber = Convert.ToInt32(Regex.Replace(strArray[0], @"[^\d]+", ""));
            secondNumber = Convert.ToInt32(Regex.Replace(strArray[1], @"[^\d]+", ""));
        }
        static void GetSymbolFromString(string str, out char symbol)
        {         
            symbol = Convert.ToChar(Regex.Replace(str, @"[^\W]+", ""));                           
        }
        static void MathOperation(int firstNumber, int secondNumber, char symbol)
        {
            int result = default;
            switch (symbol)
            {
                case '/':
                    result = firstNumber / secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Результат: " + result);
        }
    }
}
