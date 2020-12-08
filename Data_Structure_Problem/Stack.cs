using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure_Problem
{
    public class Stack
    {
        LinkedList linkedList = new LinkedList();
        public Node head;
        public Node tail;
        public void PushElements(int element)
        {
            Node node = new Node(element);
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
            Console.WriteLine("{0} instered into List ", node.data);
        }
        public void display()
        {
            if (head == null)
                Console.WriteLine("There are No elements in the list");
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
