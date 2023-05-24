using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_task
{
    internal class Queue<T>
    {
        Node<T> front;
        Node<T> rear;

        public Queue()
        {
            front = null;
            rear = null;
        }
        public void Enqueue(T item)
        {
            //adds an item to the tail of the queue
            Node<T> temp = new Node<T>(item);
            if(this.rear == null)
            {
                this.front = temp;
                this.rear = temp;
            }
            this.rear.Pointer = temp;
            this.rear = temp;
        }

        //removes and returns the item at the head of the queue
        public void Dequeue(T item)
        {
          
            if (this.front == null)
                return;
            Node<T> temp = this.front;
            this.front = this.front.Pointer;

            //chenges rear to null if front is also null
            if (this.front == null)
                this.rear = null;
        }

        public bool IsEmpty() 
        {
            return front == null;
        }
        public int Size()
        {
            Node<T> current = front;
            if (current == null)
            {
                return 0;
            }
            int counter = 1;

            while (current.Pointer != null)
            {
                current = current.Pointer;
                counter++;
            }
            return counter;
        }
        public void PrintQueueNode()
        {
            Node<T> Current = front;
            while (Current != null)
            {
                Console.WriteLine("Value of a Node is {0}", Current.Data);
                Current = Current.Pointer;
            }
        }
    }
}