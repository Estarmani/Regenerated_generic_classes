using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_task
{
    public class LinkedList<T>
    {
        public Node<T> Head;
        public Node<T> Current;
        public Node<T> Previous;
        public int count;

        public LinkedList()
        {
            Head = null;
            Current = null;
            Previous = null;
            count = 0;
        }

        public void AddTail(T data)
        {
            Node<T> FirstNode = new Node<T>(data);
            
            if(Head == null)
            {
                Head = FirstNode;
                return;
            }
            else
            {
                Current = Head;
                while(Current != null)
                {
                    Current = Current.Pointer;
                }
                Current.Pointer = FirstNode;
            }
          
        }
        
        public bool RemoveHead(T Item)
        {
            Node<T> currentNode = Head;

            while(currentNode.Pointer != null) 
            {
                if (Item.Equals(Current.Data))
                {
                    if (Previous != null)
                    {
                        Previous.Pointer = Current.Pointer;
                    }
                    else
                    {
                        Head = Current.Pointer;
                    }
                    return true;
                }
                Previous = Current;
                Current = Current.Pointer;
            }
            return false;
        }
        public bool Check(T value)
        {
            Node<T> currentCheck = Head;
            while (Current!= null)
            {
                if (value.Equals(Current.Data))
                {
                    return true;
                }
                Current = Current.Pointer;
            }
            return false;
        }

        public int Index(T value)
        {
            while(Current != null)
            {
                if (value.Equals(Current.Data))
                {
                    return count;
                }
                Current = Current.Pointer;
                count++;
            }
            return count;
        }

        public void printLinkedList()
        {
            Current = Head;
            while (Current != null)
            {
                Console.WriteLine("Value of Node is {0}", Current.Data);
                Current = Current.Pointer;
            }
        }
    }
    
}
