using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public  class Node
    {
        public int data;
        public Node Next; // Address of Next Node

        //constructor..................
        public Node(int data) 
        { 
            this.data = data;
        }
    }
}
