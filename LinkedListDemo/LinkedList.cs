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
        public void AddNode(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head; //Stroing last Data In temp Variable...
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;

            }
            Console.WriteLine("{0} Linked List", node.data);

        }

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


        // Removed First Element.... 
        public void RemoveAtFirst()
        {
            if(this.head==null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                this.head = this.head.next;
                Console.WriteLine("First element Removed !!");
            }
        }

        //Remove at Last..................
        public void RemoveAtLast()
        {
            if( this.head==null)
            {
                Console.WriteLine("Linked list is empty");

            }
            if(this.head.next == null)
            {
                this.head = null;
            }
            Node lastNode = this.head;
            while(lastNode.next.next != null)
            {
                lastNode = lastNode.next;
            }
            lastNode.next = null;
        }

        // size of node........
        public void SizeofNode()
        {
            Node temp = head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                //Console.WriteLine(temp.data);
                temp = temp.next;
                count++;
            }
            Console.WriteLine("Size of Node : "+count);

        }

        //Insert Data from the given position.
        public void InsertNodeSpecificPosit(int position, int data)
        {
            Console.WriteLine($"Position is entered : {position} and Data is : {data}");
            if (position == 0)
            {
                ReverseAddElement(data);
                return;
            }
            Node newNode = new Node(data);
            Node temp = head;
            int count = 1;
            while (count < position - 1)
            {
                temp = temp.next;
                count++;
            }
            newNode.next = temp.next;
            temp.next = newNode;
        }

        //Delete Node or Data from the given Position.
        public void DeleteNodeAtSpecificPosition(int position)
        {
            Console.WriteLine($"Position : {position}");
            if (position == 1)
            {
                head = head.next;
            }
            else
            {
                Node current = head;
                Node previous = null;
                int count = 1;
                while (count <= position - 1)
                {
                    previous = current;
                    current = current.next;
                    count++;
                }
                previous.next = current.next;

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