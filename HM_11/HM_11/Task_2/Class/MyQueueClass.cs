using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Class
{
    class MyQueueClass<T> where T : class
    {
        public LinkedList<T> ClassQueue = new LinkedList<T>();
    }
}
