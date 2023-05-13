using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class LinkedList
    {
        public Node head; ////Empty node To point
        //public void AddNode(int data)
        //{
        //    Node node = new Node(data);
        //    if (this.head == null)
        //    {
        //        this.head = node;
        //    }
        //    else
        //    {
        //        Node temp = head; //Stroing last Data In temp Variable...
        //        while (temp.next != null)
        //        {
        //            temp = temp.next;
        //        }
        //        temp.next = node;

        //    }
        //    Console.WriteLine("{0} Linked List", node.data);

        //}

        // Reverse Data element.............
        public void ReverseAddElement(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = head;
                head = newNode;
                head.next = temp;
            }

        }

        //Display 
        public void Display()
        {
            Node temp = head; // 
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}