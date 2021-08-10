using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_task2
{
    class Person
    {
        string name;

        public Person (string _name)
        {
            name = _name;
        } 

        public void ShowData(SmallApartment apartment)
        {
            Console.WriteLine($"My name {name}");
            apartment.ShowData();
            apartment.GetDoor();           
        }
    }
}
