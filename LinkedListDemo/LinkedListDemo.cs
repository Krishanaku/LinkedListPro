using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPrac
{
    public class LinkedListDemo
    {
        public void Method()
        {
            LinkedList<int> linkedlist = new LinkedList<int>();
            linkedlist.AddLast(1);
            linkedlist.AddLast(2);
            linkedlist.AddLast(3);
            linkedlist.AddLast(4);
            linkedlist.AddLast(5);
            linkedlist.AddLast(6);
            //foreach(int o in linkedlist)
            //{
            //    Console.Write($"{o} ");
            //}
            //AddFirst
            linkedlist.AddFirst(50);
            linkedlist.AddFirst(30);
            linkedlist.AddFirst(80);
            Console.WriteLine("Count : " + linkedlist.Count);
            //linkedlist.Clear();
            //Remove(linkedlistnode) : 
            linkedlist.Remove(linkedlist.Last);
            linkedlist.Remove(30);
            linkedlist.RemoveFirst();
            linkedlist.RemoveLast();

            foreach (int i in linkedlist)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("Count : " + linkedlist.Count);
        }


    }
}