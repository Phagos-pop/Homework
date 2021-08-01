using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Class;
using Task_2.Interface;

namespace Task_2.Servises
{
    class MyQueueClassServise : IMyQueue
    {
        MyQueueClass<MyQueueDateTimeServise> myQueue;

        public MyQueueClassServise()
        {
            myQueue = new MyQueueClass<MyQueueDateTimeServise>();
        }

        public object Dequeue()
        {
            if (myQueue.ClassQueue.Count == 0)
            {
                return "Очередь пуста";
            }

            var last = myQueue.ClassQueue.Last.Value;

            myQueue.ClassQueue.RemoveLast();

            return last;
        }

        public void Enqueue(MyQueueDateTimeServise type)
        {
            myQueue.ClassQueue.AddFirst(type);
        }

        public object Peek()
        {
            if (myQueue.ClassQueue.Count == 0)
            {
                return "Очередь пуста";
            }
            return myQueue.ClassQueue.Last.Value;
        }
    }
}
