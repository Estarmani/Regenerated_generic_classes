using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_task
{
    public class StackWithLinkedList<T>
    {
        Node<T> top;

        public StackWithLinkedList()
        {
            top = null;  
        }

        public void push(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (top == null)
            {
                newNode.Pointer = null;
            }
            else
            {
                newNode.Pointer = top;
            }
            top = newNode; 
        }
        public bool IsEmpty()
        {
            return top == null;
        }

        public T Peek()
        {
            if (!IsEmpty())
            {
                return top.Data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return default;
            }
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return; 
            }
            top = top.Pointer;
            Console.WriteLine(top.Data);
        }

        public int size()
        {
            Node<T> currentSize = top;
            if(currentSize == null)
            {
                return 0;
            }
            int Counter = 1;

            while(currentSize.Pointer != null)
            {
                currentSize = currentSize.Pointer;
                Counter++;
            }
            return Counter;
        }

        public void printStackNode()
        {
            Node<T> current = top;
            while(current != null)
            {
                Console.WriteLine("Value of a Stack Node is {0}", current.Data);
                current = current.Pointer;
            }
        }
    }
            
}