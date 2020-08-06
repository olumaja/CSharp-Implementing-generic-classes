using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplexDataStructures
{
    class GenericQueue<T> : ICollection<T>
    {

        LinkedList<string> checkerList = new LinkedList<string>(); //Instantiate linked list
        string printerValue = "---------------------------------------------------------------\n";

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

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

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
