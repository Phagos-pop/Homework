using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Class;
using Task_2.Interface;


namespace Task_2.Servises
{
    class MyQueueObjectServise : IMyQueue  
    {
        MyQueueObject myQueue;

        public MyQueueObjectServise()
        {
            myQueue = new MyQueueObject();
        }

        public object Dequeue()
        {
            if (myQueue.ObjectQueue.Count == 0)
            {
                return "Очередь пуста";
            }

            object last = myQueue.ObjectQueue[myQueue.End];

            myQueue.ObjectQueue.RemoveAt(myQueue.End);

            myQueue.Start--;

            return last;
        }

        public void Enqueue(object o)
        {
            myQueue.ObjectQueue.Add(o);
            myQueue.Start++;
        }

        public object Peek()
        {
            if (myQueue.ObjectQueue.Count == 0)
            {
                return "Очередь пуста";
            }
            return myQueue.ObjectQueue[myQueue.End];
        }
    }
}
