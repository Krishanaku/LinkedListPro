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

            LinkedList linkedList = new LinkedList();
            Console.WriteLine("Choose the following");
            Console.WriteLine("1.Add Element to linked list\n2.Add Elements in reverse order\n3.Remove first element" +"\n4.Remove last Element"
                );
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    linkedList.AddNode(56);
                    linkedList.AddNode(30);
                    linkedList.AddNode(70);
                    linkedList.Display();
                    break;
                case 2:
                    linkedList.ReverseAddElement(90);
                    linkedList.ReverseAddElement(100);
                    linkedList.ReverseAddElement(110);
                    linkedList.Display();
                    break;
                 
                case 3:
                    linkedList.AddNode(90);
                    linkedList.AddNode(100);
                    linkedList.AddNode(110);
                    linkedList.RemoveAtFirst();
                    linkedList.Display();
                    break;
                case 4:
                    linkedList.AddNode(90);
                    linkedList.AddNode(100);
                    linkedList.AddNode(110);
                    linkedList.RemoveAtLast();
                    linkedList.Display();
                    break;

                default:
                    Console.WriteLine("Option is not Found !!!");
                    break;
            }
            Console.ReadLine();


        }
    }
}
