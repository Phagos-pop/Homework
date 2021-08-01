using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Class
{
    class MyQueueObject
    {
        public List<object> ObjectQueue = new List<object>();  
        public int Start { get; set; }
        public int End { get; set; }
    }
}
