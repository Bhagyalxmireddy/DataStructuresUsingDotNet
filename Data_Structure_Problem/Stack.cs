using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure_Problem
{
    public class Stack
    {
        LinkedList linkedList = new LinkedList();
        public Node top;
        public Node tail;
        public void PushElements(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
            {
                this.top = node;
            }
            if (this.tail == null)
            {
                tail = node;
            }
            else
            {
                Node tempNode = this.top;
                this.top = node;
                this.top.next = tempNode;
            }
            Console.WriteLine("{0} instered into List ", node.data);
        }

        public void display()
        {
            if (top == null)
                Console.WriteLine("There are No elements in the list");
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
        public int peek()
        {
           /* if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return 0;
            }
            Console.WriteLine("{0} is the Top of stack", this.top.data);*/
            return this.top.data;
        }
        public Node pop()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return null;
            }
            Node temp = top;
            top = top.next;
            return temp;
        }
        public void Is_Empty()
        {
            while(this.top != null)
            {
                pop();
                peek();
            }
        }
    }
}
