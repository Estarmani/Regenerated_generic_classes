using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_task
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Pointer;

        public Node(T data)
        {
            Data = data;
            Pointer = null;
          
        }
    }
}
