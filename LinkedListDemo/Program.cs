using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //UC1...................
            LinkedList linkedList = new LinkedList();
            //linkedList.AddNode(56);
            //linkedList.AddNode(30);
            //linkedList.AddNode(70);

            // uc2.................
            linkedList.ReverseAddElement(100);
            linkedList.ReverseAddElement(110);
            linkedList.ReverseAddElement(120);
            linkedList.Display();
            Console.ReadLine();


        }
    }
}
