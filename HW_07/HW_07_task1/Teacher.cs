using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_task1
{
    sealed class Teacher : Person
    {
        string subject;

        public void Explain()
        {
            Console.WriteLine("Explanation begins.");
        }
    }
}
