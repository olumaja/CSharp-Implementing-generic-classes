using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplexDataStructures
{
    class GenericQueue
    {

        LinkedList<string> checkerList = new LinkedList<string>(); //Instantiate linked list
        string printerValue = "---------------------------------------------------------------\n";

        public void Enqueue()
        {
            //Add item into queue
            Console.Write("Enter any item into the Queue: ");
            string itemName = Console.ReadLine();
            Console.WriteLine();
            checkerList.AddTail(char.ToUpper(itemName[0]) + itemName.Substring(1).ToLower()); //Add to the queue head
            Console.WriteLine($"{char.ToUpper(itemName[0])}{itemName.Substring(1).ToLower()} was push into queue");
            Console.WriteLine();
            printerValue += $"{char.ToUpper(itemName[0])}{itemName.Substring(1).ToLower()} was push into queue\n"; //message to print
        }

        public void Dequeue()
        {
            //Remove the first item from the queue
            var messages = checkerList.RemoveFisrtItem();
            printerValue += messages + " was dequeue out of the queue\n";
            Console.WriteLine(messages + " was dequeue out of the queue");
            Console.WriteLine();
        }

        //Check if queue is empty
        public bool IsEmpty()
        {

            return checkerList.Size == 0;
        }

        //Display queue size
        public void Sizes()
        {
            printerValue += "The size of stack is " + checkerList.Size + "\n";
            Console.WriteLine("The size of stack is " + checkerList.Size);
            Console.WriteLine();
        }

        //Print the latest operation
        public void Print()
        {
            printerValue += "---------------------------------------------------------------\n";
            Console.WriteLine(printerValue);
            Console.WriteLine();
        }

        

    }
}
