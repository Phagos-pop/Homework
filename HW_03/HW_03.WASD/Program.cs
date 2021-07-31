using System;
using System.IO;
using System.Windows;

namespace HW_03.WASD
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите ч чтоб выйти");

            ConsoleKeyInfo keyinfo;
            do
            {                
                keyinfo = Console.ReadKey();
                switch (keyinfo.Key)
                {
                    case ConsoleKey.W:
                        Console.WriteLine(" Вверх");
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine(" Влево");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine(" Вправо");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine(" Вниз");
                        break;
                    default:
                        Console.WriteLine(" Вы не туда нажали");
                        break;
                }
            }
            while (keyinfo.Key != ConsoleKey.X);
        }
    }
}

