using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07.Booking.Com.Models
{
     sealed class Person
    {
        string login;
        Guid guid = Guid.NewGuid();
        string mail;
        string Mail
        {
            set
            {
                var addr = new System.Net.Mail.MailAddress(value);
                if (addr.Address == value)
                {
                    mail = value;
                }
                else
                {
                    throw new Exception("Не правельная электронная почта.");
                }
            }
        }
        string password;
        string Password
        {
            set
            {
                if (value.Length > 8)
                {
                    password = value;
                }
                else
                    throw new Exception("Длина пароля меньше 8 символов.");
            }
        }

        internal Person ()
        {
            Console.WriteLine("Введите ваш логин: ");
            login = Console.ReadLine();
            ValidEmail();
            ValidPassword();
        }

        internal void ValidPassword()
        {
            bool test = false;
            do
            {
                Console.WriteLine("Введите ваш пароль: ");
                string _password = Console.ReadLine();
                try
                {
                    Password = _password;
                    test = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Исключение: {ex.Message}");
                    Console.WriteLine($"Метод: {ex.TargetSite}");
                }                
            } while (!test);            
        }
        internal void ValidEmail()
        {
            bool test = false;
            do
            {
                Console.WriteLine("Введите вашу электронную почту: ");
                string _mail = Console.ReadLine();
                try
                {
                    Mail = _mail;
                    test = true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Исключение: {ex.Message}");
                    Console.WriteLine($"Метод: {ex.TargetSite}");
                }
            } while (!test);
        }
    }
}
