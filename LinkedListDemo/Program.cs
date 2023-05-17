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

            //LinkedList linkedList = new LinkedList();
            //Console.WriteLine("Choose the following");
            //Console.WriteLine("1.Add Element to linked list\n2.Add Elements in reverse order\n3.Remove first element" +"\n4.Remove last Element"
            //   +"\n5. Size of Node" );
            //int option = Convert.ToInt32(Console.ReadLine());
            //switch (option)
            //{
            //    case 1:
            //        linkedList.AddNode(56);
            //        linkedList.AddNode(30);
            //        linkedList.AddNode(70);
            //        linkedList.Display();
            //        break;
            //    case 2:
            //        linkedList.ReverseAddElement(90);
            //        linkedList.ReverseAddElement(100);
            //        linkedList.ReverseAddElement(110);
            //        linkedList.Display();
            //        break;

            //    case 3:
            //        linkedList.AddNode(90);
            //        linkedList.AddNode(100);
            //        linkedList.AddNode(110);
            //        linkedList.RemoveAtFirst();
            //        linkedList.Display();
            //        break;
            //    case 4:
            //        linkedList.AddNode(90);
            //        linkedList.AddNode(100);
            //        linkedList.AddNode(110);
            //        linkedList.RemoveAtLast();
            //        linkedList.Display();
            //        break;
            //    case 5:
            //        linkedList.AddNode(90);
            //        linkedList.AddNode(100);
            //        linkedList.AddNode(110);
            //        linkedList.SizeofNode();
            //        //linkedList.Display();
            //        break;

            //    default:
            //        Console.WriteLine("Option is not Found !!!");
            //        break;
            //}
            //Console.ReadLine();

            //LinkedList.....

            LinkedList linkedListt = new LinkedList();
            //linkedListt.AddNode(56);
            //linkedListt.AddNode(13);
            //linkedListt.AddNode(70);
            //linkedListt.ReverseAddElement(90);
            //linkedListt.ReverseAddElement(100);
            //linkedListt.ReverseAddElement(70);
            //linkedListt.RemoveAtFirst();
            //linkedListt.RemoveAtLast();
            //linkedListt.SizeofNode();
            //linkedListt.Display();
            linkedListt.InsertNodeSpecificPosit(0, 205);
            linkedListt.InsertNodeSpecificPosit(1, 68);
            linkedListt.InsertNodeSpecificPosit(2, 232);
            linkedListt.InsertNodeSpecificPosit(3, 20);
            linkedListt.Display();
            linkedListt.DeleteNodeAtSpecificPosition(2);
            linkedListt.Display();
            //linkedListt.Sorting(65);
            //linkedListt.Sorting(2);
            //linkedListt.Sorting(50);
            //linkedListt.Sorting(69);
            //linkedListt.Display();
            Console.ReadLine();

        }
    }
}
