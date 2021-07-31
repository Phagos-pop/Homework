using System;

namespace HW_03.Calculator
{
    class Calculator
    {
        public string firstNumber;
        public string secondNumber;

        public Calculator(string number1, string number2) { firstNumber = number1; secondNumber = number2; }

        public void Add()
        {            
            int a = Convert.ToInt32(firstNumber);
            int b = Convert.ToInt32(secondNumber);
            Console.WriteLine($"Сумма чисел: " + (a + b));
        }

        public void Subtraction()
        {
            int a = Convert.ToInt32(firstNumber);
            int b = Convert.ToInt32(secondNumber);
            Console.WriteLine($"Вычитание чисел: " + (a - b));
        }

        public void Multiplication()
        {
            int a = Convert.ToInt32(firstNumber);
            int b = Convert.ToInt32(secondNumber);
            Console.WriteLine($"Умножение чисел: " + (a * b));
        }

        public void Segmentation()
        { 
            int a = int.Parse(firstNumber);
            int b = int.Parse(secondNumber);
            Console.WriteLine($"Деление чисел: " + (a / b));
        }

        public void RemainderDivision()
        {
            int a = int.Parse(firstNumber);
            int b = int.Parse(secondNumber);
            Console.WriteLine($"Деление с остатком: " + (a % b));
        }

        public void Square()
        {
            int a = int.Parse(firstNumber);
            float b = 3.14f;
            double result = (a * a * b);
            Console.WriteLine($"Площадь круга: " + result);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string number1;
            Console.WriteLine("Введите первое число: ");
            number1 = Console.ReadLine();

            string number2;
            Console.WriteLine("Введите второе число: ");
            number2 = Console.ReadLine();

            Calculator calc = new Calculator(number1,number2);

            calc.Add();
            calc.Subtraction();
            calc.Multiplication();
            calc.Segmentation();
            calc.RemainderDivision();
            calc.Square();
        }
    }
}
