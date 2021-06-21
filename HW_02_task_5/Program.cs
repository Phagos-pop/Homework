using System;


namespace HW_02_task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'a' number: ");
            short a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter 'b' number: ");
            short b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter 'c' number: ");
            short c = Convert.ToInt16(Console.ReadLine());

            double D = (b * b) - (4 * a * c);
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
                double x2 = (-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);

                Console.WriteLine($"Equation answer: {x1}; {x2}");
            }
            if (D == 0)
            {
                double x1 = (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
                Console.WriteLine($"Equation answer: {x1}");
            }
            if (D < 0)
            {
                Console.WriteLine("The equation have no answer");
            }
        }
    }
}
