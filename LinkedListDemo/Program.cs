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
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
            Console.ReadLine();


        }
    }
}
