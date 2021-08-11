using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interface;
using Task_2.Class;

namespace Task_2.Servises
{
    class MyQueueDateTimeServise : IMyQueue
    {
        MyQueueDateTime myQueue;  

        public MyQueueDateTimeServise()
        {
            myQueue = new MyQueueDateTime();
        }

        public object Dequeue()
        {
            if (myQueue.DateTimeQueue.Count == 0)
            {
                return "Очередь пуста";
            }

            DateTime last = myQueue.DateTimeQueue.Last.Value;

            myQueue.DateTimeQueue.RemoveLast();

            return last;
        }

        public void Enqueue(DateTime date)
        {
            myQueue.DateTimeQueue.AddFirst(date);
        }

        public object Peek()
        {
            if (myQueue.DateTimeQueue.Count == 0)
            {
                return "Очередь пуста";
            }
            return myQueue.DateTimeQueue.Last.Value;
        }
    }
}
