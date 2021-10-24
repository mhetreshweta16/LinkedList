using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CustomLinkedList list = new CustomLinkedList();
            list.InsertLast(56);
            list.InsertLast(30);
            list.InsertLast(70);
            list.display();
        }
    }
}
