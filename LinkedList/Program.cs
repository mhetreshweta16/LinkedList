using System;

namespace LinkedList
{
    class Program
    {
        /// <summary>
        /// Linked List 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedListQueue listQueue = new LinkedListQueue();
            listQueue.Enqueue(50);
            listQueue.Enqueue(30);
            listQueue.Enqueue(70);
            Console.WriteLine("the Queue list is:");
            listQueue.Display();
            listQueue.Dequeue();
            Console.WriteLine("the Deueue list is:");
            listQueue.Display();
            

            //stack operations
            /*LinkedListStack  listStack = new LinkedListStack();
            listStack.push(50);
            listStack.push(30);
            listStack.push(70);
            Console.WriteLine("the stack list is:");
            listStack.display();
            listStack.Peek();
            listStack.Pop();
            Console.WriteLine("after the pop list is");
            listStack.display();
            listStack.IsEmpty();*/
            //Linked list
            /* Console.WriteLine("afete adding the new node list is");
             list.insertAfterNode(30, 40);
             list.display();
             list.size();
             Console.WriteLine("afete deleting specific node list is:");
             list.deleteSpecificNode(40);
             list.display();
             list.size();*/


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
