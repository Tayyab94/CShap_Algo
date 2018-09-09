using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class QuerClASS
    {
        private int mazSize;

        private long[] MyQue;
        private int front;
        private int rear;

        private int item;


        public QuerClASS(int s)
        {
            this.mazSize = s;

            MyQue = new long[s];

            front = 0;
            rear = -1;
            item = 0;
        }


        public void inQue(long d)
        {
            if(IsFull())
            {
                Console.WriteLine("Queue is Full");
            }
            else
            {
                if(rear==mazSize-1)
                {
                    rear = -1;
                }
                rear++;
                MyQue[rear] = d;
                item++;
            }
        }


        public long Peak()
        {
            return MyQue[front];    
        }

        public long Remove()
        {
            long temp = MyQue[front];

            front++;

            if(front==mazSize)
            {
                front = 0;
            }
            return temp;
        }

        private bool IsFull()
        {
            return (item == mazSize);
        }



        public void view()
        {
            Console.Write("[");

            for(int i=0; i<MyQue.Length;i++)
            {
                Console.Write(MyQue[i] + " ");
            }

            Console.WriteLine("]");
        }
    }


    public class BuiltInQueue
    {

        public static void Demo()
        {
            Queue<string> queue = new Queue<string>();


            queue.Enqueue("ALi");

            queue.Enqueue("Ahamd");

            queue.Enqueue("Raza");


            queue.Enqueue("Hammad");

            Console.WriteLine("Default Content of the Queue");

            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }


           Console.WriteLine($"DEqueing item = > {queue.Dequeue()}");

            Console.WriteLine($"After Dequeueing the item the PEAK element is  =>{queue.Peek()}");


            Queue<string> queue1 = new Queue<string>(queue.ToArray
                ());


            Console.WriteLine("Content is Now Coping");

            foreach (string ite1 in queue1)
            {
                Console.WriteLine(ite1);
            }


            string[] arrayQueue = new string[queue.Count*2];

            queue.CopyTo(arrayQueue, queue.Count);


            foreach (var i in arrayQueue)
            {
                Console.WriteLine(i);
            }


            Queue<string> Q2 = new Queue<string>(queue.ToArray());


            foreach (var q in Q2)
            {
                Console.WriteLine(q);
            }
        }
    }
}
