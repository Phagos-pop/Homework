using System;
using System.Collections;
using Task_2.Servises;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueueDateTimeServise myQueueTime = new MyQueueDateTimeServise();
            myQueueTime.Enqueue(DateTime.Now);
            myQueueTime.Enqueue(DateTime.MinValue);
            Console.WriteLine(myQueueTime.Peek());
            Console.WriteLine(myQueueTime.Dequeue());
            Console.WriteLine(myQueueTime.Dequeue());
            MyQueueDateTimeServise myQueueTime2 = new MyQueueDateTimeServise();
            Console.WriteLine(myQueueTime2.Peek()); 

            MyQueueObjectServise myQueueObject = new MyQueueObjectServise();
            Console.WriteLine(myQueueObject.Peek());
            myQueueObject.Enqueue(1);
            myQueueObject.Enqueue(2);
            myQueueObject.Enqueue(3);
            Console.WriteLine(myQueueObject.Peek());
            Console.WriteLine(myQueueObject.Dequeue());
            Console.WriteLine(myQueueObject.Peek());
            Console.WriteLine(myQueueObject.Dequeue());
            Console.WriteLine(myQueueObject.Peek());
            MyQueueObjectServise myQueueObject2 = new MyQueueObjectServise();
            myQueueObject2.Enqueue(5);
            myQueueObject2.Enqueue(6);
            myQueueObject2.Enqueue(7);
            Console.WriteLine(myQueueObject2.Peek()); 
            Console.WriteLine(myQueueObject2.Dequeue()); ;

            MyQueueClassServise myQueueClass = new MyQueueClassServise();
            myQueueClass.Enqueue(myQueueTime);
            Console.WriteLine(myQueueClass.Peek());
            Console.WriteLine(myQueueClass.Dequeue());
            Console.WriteLine(myQueueClass.Dequeue());
        }
    }
}
