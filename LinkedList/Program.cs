using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CustomLinkedList list = new CustomLinkedList();
            list.InsertFirst(70);
            list.InsertFirst(30);
            list.InsertFirst(50);
            Console.WriteLine("after the inserting node the list is:");
            list.display();
        }
    }
}
