using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Interface
{
    interface IMyQueue
    {
        virtual void Enqueue() { }
        object Dequeue();
        object Peek();
    }
}
