using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure_Problem
{
    public class LinkedList
    {
        internal Node head;
        internal Node tail;
        public void Add(int data)
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
            Console.WriteLine("{0} instered into List ", node.data);
        }
        public void Display()
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
        public void Append(int data)
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
        public void Insert(int position,int data)
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;
                    while (position > 2)
                    {
                        temp = temp.next;
                        position--;
                    }
                    node.next = temp.next;
                    temp.next = node;
            }
            Console.WriteLine("The inserted middle element is : " + node.data);
        }
        public Node pop()
        {
            if(head == null)
            {
                Console.WriteLine("There is no element to delete in the list");
            }
            Node temp = head;
            head = head.next;
            return temp;        
        }
        public Node popLast()
        {
            if (head == null)
            {
                Console.WriteLine("There is No element to delete in the list");
                return null;
            }
            else
            {
                Node temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                Node finalNode = temp.next;
                temp.next = null;
                this.tail = temp;
                return finalNode;
            }
        }
        public void RemoveElemet(int key)
        {
            Node temp = head, previous = null;
            if (temp != null && temp.data == key)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                previous = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;
            previous.next = temp.next;
        }
        public int Search(int key)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == key)
                {
                    return temp.data;
                }
                temp = temp.next;
            }
            return 0;
        }
        public int sizeOfList()
        {
            Node tempNode = this.head;
            int size = 0;
            while (tempNode != null)
            {
                size++;
                tempNode = tempNode.next;
            }
            return size;
        }
        public int CheckFirstElement()
        {
            return this.head.data;
        }

        public int CheckLastElement()
        {
            return this.tail.data;
        }

        public int CheckMiddleElement()
        {
            return this.head.next.data;
        }
    }
}
