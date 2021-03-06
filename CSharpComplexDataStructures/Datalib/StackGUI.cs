﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplexDataStructures.Datalib
{
    class StackGUI<T> : ICollection<T>
    {
        LinkedList<string> checkerList = new LinkedList<string>(); //Instantiate linked list
        string printerValue = "---------------------------------------------------------------\n";

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Push()
        {
            //Push item into stack
            Console.Write("Enter any item to push into the Stack: ");
            string itemName = Console.ReadLine();
            Console.WriteLine();
            checkerList.AddTail(char.ToUpper(itemName[0]) + itemName.Substring(1).ToLower()); //Add to the stack from head
            Console.WriteLine($"{char.ToUpper(itemName[0])}{itemName.Substring(1).ToLower()} was push into stack");
            Console.WriteLine();
            printerValue += $"{char.ToUpper(itemName[0])}{itemName.Substring(1).ToLower()} was push into stack\n"; //message to print
        }

        public void Pop()
        {

            //Pop the last item from the stack
            var messages = checkerList.RemoveLast();
            printerValue += messages + " was pop out of the stack\n";
            Console.WriteLine(messages + " was pop out of the stack");
            Console.WriteLine();
        }

        //Return the last item in the stack
        public string Peek()
        {
            printerValue += "Peek return " + checkerList.Tall.Value + "\n";
            return checkerList.Tall.Value;
        }

        //Check if stack is empty
        public bool IsEmpty()
        {
            
            return checkerList.Size == 0;
        }

        //Display stack size
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
