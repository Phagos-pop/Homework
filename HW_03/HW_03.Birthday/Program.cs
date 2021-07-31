using System;

namespace HW_03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            bool test = true;
            short dayOfBirthday = 0;
            short monthOfBirthday = 0;
            short yearOfBirthday = 0;
            do
            {
                try
                {
                    do
                    {
                        Console.WriteLine("Введите число рождения: ");
                        dayOfBirthday = Convert.ToInt16(Console.ReadLine());
                    } while (dayOfBirthday >= 31 && dayOfBirthday < 0);

                    do
                    {
                        Console.WriteLine("Введите месяц рождения: ");
                        monthOfBirthday = Convert.ToInt16(Console.ReadLine());
                    } while (monthOfBirthday >= 12 && monthOfBirthday < 0);

                    do
                    {
                        Console.WriteLine("Введите год рождения: ");
                        yearOfBirthday = Convert.ToInt16(Console.ReadLine());
                    } while (yearOfBirthday < 0);
                    Console.WriteLine($"Дата вашего рождения: {dayOfBirthday} {monthOfBirthday} {yearOfBirthday} ");
                }
                catch (Exception)
                {
                    Console.WriteLine("Неправельный ввод;");
                    test = false;
                    continue;
                }
            } while (!test);

            short dayOfToday = 0;
            short monthOfToday = 0;
            short yearOfToday = 0;
            do
            {
                try
                {
                    do
                    {
                        Console.WriteLine("Какое число сейчас: ");
                        dayOfToday = Convert.ToInt16(Console.ReadLine());
                    } while (dayOfToday >= 31 && dayOfToday < 0);

                    do
                    {
                        Console.WriteLine("Какой сейчас месяц: ");
                        monthOfToday = Convert.ToInt16(Console.ReadLine());
                    } while (monthOfToday >= 12 && monthOfToday < 0);

                    do
                    {
                        Console.WriteLine("Какой сейчас год: ");
                        yearOfToday = Convert.ToInt16(Console.ReadLine());
                    } while (yearOfToday < 0);
                    Console.WriteLine($"Сегодняшнее число : {dayOfToday} {monthOfToday} {yearOfToday} ");
                }
                catch (Exception)
                {
                    Console.WriteLine("Неправельный ввод;");
                    test = false;
                    continue;
                }
            } while (!test);
            short howManyYear = (short)(yearOfToday - yearOfBirthday);
            if (monthOfToday < monthOfBirthday)
            {
                --howManyYear;
            }
            else if (monthOfToday == monthOfBirthday)
            {
                if (dayOfToday < dayOfBirthday)
                {
                    --howManyYear;
                }
                else if (dayOfToday == dayOfBirthday)
                {
                    Console.WriteLine("Сегодня ваше день рождения. Поздровляю!");
                }
                
            }
            Console.WriteLine($"Вам {howManyYear} полных лет."); 
        }
    }
}
