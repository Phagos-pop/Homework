using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_task2
{
    class House
    {
        public int area { set; get; }

        public House(int _area)
        {
            area = _area;
        }
        public void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {area} m2");
        }
        public void GetDoor()
        {
            Door door = new Door("Red");
            door.ShowData();
        }
    }
}
