﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Week_2_task
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddTail(1);
            list.AddTail(2);
            list.AddTail(7);
            list.AddTail(15);
            list.printLinkedList();

            Console.WriteLine(list.Check(7));
            list.RemoveHead(15);
            list.printLinkedList();

           
        }
    }
}
