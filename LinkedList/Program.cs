using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CustomLinkedList list = new CustomLinkedList();

            list.InsertLast(50);
            list.InsertLast(30);
            list.InsertLast(70);
            Console.WriteLine("the list is:");
            list.display();
            Console.WriteLine("afete adding the new node list is");
            list.insertAfterNode(30, 40);
            list.display();
            Console.WriteLine("afete deleting specific node list is:");
            list.deleteSpecificNode(40);
            list.display();


            // list.Search(50);
            //delete last node
            /*list.deleteLastNode();
            list.display();*/

            //deleting first node
            /* list.deleteFirstNode();
             */

            //insert node at specific position
            /*list.InsertLast(50);
            list.InsertLast(70);
            Console.WriteLine("after insert node at specific position");
            list.specificPostition(2, 30);
            list.display();*/

            //Append the node
            /*list.Append(50);
            list.Append(30);
            list.Append(70);
            Console.WriteLine("After appending the node the list is:");
            list.display();*/

            //Insert First
            /*list.InsertFirst(70);
            list.InsertFirst(30);
            list.InsertFirst(50);
            Console.WriteLine("after the inserting node the list is:");*/

        }
    }
}
