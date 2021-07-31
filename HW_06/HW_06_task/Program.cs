using System;
using HW_06_task2;

namespace HW_06_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle motorcycle_1 = new Motorcycle();
            Motorcycle motorcycle_2 = new Motorcycle();
            Motorcycle motorcycle_3 = new Motorcycle();

            Console.WriteLine("Первый мотоцикл.");
            motorcycle_1.Create();
            Console.WriteLine("Второй мотоцикл.");
            motorcycle_2.Create();
            Console.WriteLine("Третий мотоцикл.");
            motorcycle_3.Create();

            Motorcycle[] arrayOfMotorcycle = Motorcycle.GetMotorcycleArray(motorcycle_1, motorcycle_2, motorcycle_3);

            Motorcycle.PrintMotorcycleArray(arrayOfMotorcycle);

        }
    }
}
