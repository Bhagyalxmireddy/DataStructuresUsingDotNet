using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure_Problem
{
    public class LinkedList
    {
        internal Node head;
        internal Node tail;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.tail == null)
            {
                tail = node;
            }
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node tempNode = this.head;
                this.head = node;
                this.head.next = tempNode;
            }
            Console.WriteLine("{0} instered into linkedList ", node.data);
        }
        internal void Display()
        {
            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
