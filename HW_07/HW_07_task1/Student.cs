using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_task1
{
    sealed class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I’m going to class.");          
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is: {age} years old");
        }
    }
}
