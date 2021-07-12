using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_task2
{
    class Door
    {
        public string color { get; set; }

        public Door(string _color) 
        {
            color = _color;
        }

        public void ShowData()
        {
            Console.WriteLine($"I am a door, my color is {color}");
        }        
    }
}
