using System;

namespace HW_03.Operators
{
    class Program
    {
       
        static void adding()
        {
            short firstNumber = 1;
            short secondNumber = 1;
            short answerOfNumbers = 1;
            short input = 1;
            bool test = true;
            char symbol = '1';
            do
            {
                
                try
                {
                    Console.WriteLine("Введите первое число: ");
                    firstNumber = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("Введите второе число: ");
                    secondNumber = Convert.ToInt16(Console.ReadLine());

                    do
                    {
                        Console.WriteLine("Введите + или -: ");
                        symbol = Convert.ToChar(Console.ReadLine());

                        if (symbol == '+' || symbol == '-')
                        {
                            test = true;
                        }
                        else
                        {
                            test = false;
                            continue;
                        }
                    } while (!test);
                    

                    test = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Неправельный ввод;");
                    test = false;
                    continue;
                }

                do
                {
                    try
                    {
                        Console.WriteLine($"Ответ на выражение {firstNumber} {symbol} {secondNumber} :");
                        input = Convert.ToInt16(Console.ReadLine());


                        if (symbol == '+')
                        {
                            answerOfNumbers = (short)(firstNumber + secondNumber);
                        }
                        else if (symbol == '-')
                        {
                            answerOfNumbers = (short)(firstNumber - secondNumber);
                        }


                        if (answerOfNumbers == input)
                        {
                            Console.WriteLine("Правильно;");
                            test = true;
                        }
                        else
                        {
                            Console.WriteLine("Неправильно;");

                            if (answerOfNumbers < input)
                            {
                                Console.WriteLine("Должно быть больше;");
                            }
                            else if (answerOfNumbers > input)
                            {
                                Console.WriteLine("Должно быть меньше;");
                            }

                            test = false;
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Неправельный ввод;");
                        test = false;
                    }
                } while (!test);

            } while (!test);
            
          
        }
        static void Main(string[] args)
        {
            adding();
        }
    }
}
