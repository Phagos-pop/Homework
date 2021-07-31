using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07.Booking.Com.Models
{
    class Catalog
    {
        List<string> citiesOfMinskRegion = new List<string>()
       { "Борисов", "Солигорск", "Молодечно","Слуцк", "Дзержинск","Вилейка","Марьина Горка","Стобцы","Смолевичи","Фаниполь","Несвиж","Заславль", "Логойск","Березино","Клецк","Любань","Старые Дороги","Воложин","Узда","Червень","Копыль","Крупки","Мядель"};
        string city;
        List<string> hotelsOfCity = new List<string>() { };
        string hotel;
        internal void Seach()
        {
            SeachCity();
            SeachHotel();
        }
        void SeachCity()
        {
            bool test = false;
            do
            {
                Console.WriteLine("Введите город: ");
                string _city = Console.ReadLine();
                for (int i = 0; i < citiesOfMinskRegion.Capacity; i++)
                {
                    int result = String.Compare(_city, citiesOfMinskRegion[i]);
                    if (result == 0)
                    {
                        Console.WriteLine($"Город: {citiesOfMinskRegion[i]}");
                        city = citiesOfMinskRegion[i];
                        test = true;
                        break;
                    }
                }
                if (!test)
                {
                    Console.WriteLine("Вашего города не существует.");
                }
            } while (!test);
        }
        void SeachHotel()
        {
            Console.WriteLine("Выводим все отели в городе");
            foreach (var item in hotelsOfCity)
            {
                Console.WriteLine(hotelsOfCity);
            }

           
            for (int i = 0; i < hotelsOfCity.Capacity; i++)
            {

                if (true)
                {

                }
            }
            bool test = false;
            do
            {
                Console.WriteLine("Введите отель который вам нужен: ");
                hotel = Console.ReadLine();
                for (int i = 0; i < hotelsOfCity.Capacity; i++)
                {
                    int result = String.Compare(hotel, hotelsOfCity[i]);
                    if (result == 0)
                    {
                        Console.WriteLine($"Город: {hotelsOfCity[i]}");
                        hotel = hotelsOfCity[i];
                        test = true;
                        break;
                    }
                }
                if (!test)
                {
                    Console.WriteLine("Такого отеля не существует.");
                }
            } while (!test);
        }
    }
}
