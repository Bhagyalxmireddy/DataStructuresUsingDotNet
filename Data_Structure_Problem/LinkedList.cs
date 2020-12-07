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
            if (this.head == null)
            {
                this.head = node;
            }
            if (this.tail == null)
            {
                tail = node;
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
        internal void Append(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            if (this.tail == null)
            {
                this.tail = node;
            }
            else
            {
                this.tail.next = node;
                this.tail = node;
            }
        }
        internal int CheckFirstElement()
        {
            return this.head.data;
        }

        internal int CheckLastElement()
        {
            return this.tail.data;
        }

        internal int CheckMiddleElement()
        {
            return this.head.next.data;
        }
    }
}
