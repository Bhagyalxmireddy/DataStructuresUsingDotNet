using System;

namespace Data_Structure_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To DataStructures");
            LinkedList linkedList = new LinkedList();
            linkedList.Add(70);
            //linkedList.Add(30);
            linkedList.Add(56);
            linkedList.Insert(2, 30);
            linkedList.Insert(3, 15);
            linkedList.Display();
            Console.WriteLine("\n first element in the list is : " + linkedList.CheckFirstElement());
            Console.WriteLine(" Middle elemnet in the list is : " + linkedList.CheckMiddleElement());
            Console.WriteLine(" last element in the list is : " + linkedList.CheckLastElement());
            Console.WriteLine("deleted element is :" + linkedList.CheckFirstElement());
            linkedList.pop();
            linkedList.Display();
            Console.WriteLine("\n deleted element is :" + linkedList.CheckLastElement());
            linkedList.popLast();
            linkedList.Display();
            Console.ReadLine();
        }
    }
}