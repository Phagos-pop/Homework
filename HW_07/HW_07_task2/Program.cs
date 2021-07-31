using System;

namespace HW_07_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallApartment apartment = new SmallApartment();
            Person person = new Person("Jack");
            person.ShowData(apartment);
        }
    }
}
