using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure_Problem
{
    public class Queue
    {
        LinkedList linked = new LinkedList();
        Stack stack = new Stack(); 
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (IsEmpty())
            {
                linked.Add(data);              
            }
            else
            {
                linked.Append(data);
            }
        }
        public bool IsEmpty()
        {
            return stack.Is_Empty();
        }

    }
}
