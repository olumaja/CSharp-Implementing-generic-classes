using CSharpComplexDataStructures.Datalib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplexDataStructures
{
    class LinkedList<T> : ICollection<T>
    {

        public TheNode <T> Head { get; private set; }
        public TheNode<T> Tall { get; private set; }
        public int Size { get; private set; }
        public int ItemIndex { get; private set; }
        public string Deks { get; private set; }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        //Add item to linked list
        public void AddHead(T userValue)
        {

            //Allocate new  item to the head
            TheNode<T> addedItem = new TheNode<T>(userValue);

            if (Head != null)
            {
                //if node exist before, update previous of head to new node
               
                Head.NextNode = addedItem;
                addedItem.PreviousNode = Head;  // attach the head to new node previous
                Head = addedItem;  //the new node then become the head
                Head.NextNode = null; //The next of head is set to null
            }

            

            if (Tall == null)
            {

                //If the list was empty, the tail and head are the same.
                Head = addedItem;
                //Head.NextNode = null;
                //Head.PreviousNode = null;
                Tall = Head;

            }

            Size++;  //Increment the size of the linked list.

        }

        internal object RemoveFirst()
        {
            throw new NotImplementedException();
        }

        //Add new item to the tail 
        public void AddTail(T userValue)
        {

            if (Tall == null)
            {

                //If the list was empty, the tail and head are the same.
                AddHead(userValue);
            }
            else
            {

                TheNode<T> itemAdder = new TheNode<T>(userValue);
                Tall.PreviousNode = itemAdder;
                itemAdder.NextNode = Tall;
                Tall = itemAdder;
                Tall.PreviousNode = null;
                
                Size++;
            }
            

        }

        //Remove item from linked list
        public bool Remove(T userValue)
        {
            //Determine if the user input is in the linked list, else return false
            TheNode<T> finder = Search(userValue);
            if (finder == null)
            {
                return false;
            }

            TheNode<T> previous = finder.PreviousNode;
            TheNode<T> next = finder.NextNode;

            if(previous == null)
            {
                //Item is the head node, so remove head
                Head = next;
                if(Head != null)
                {
                    Head.PreviousNode = null;
                }
            }
            else
            {
                previous.NextNode = next;
            }

            if(next == null)
            {
                //if next is null it means remove tail
                Tall = previous;
                if(Tall != null)
                {
                    Tall.NextNode = null;
                }

            }
            else
            {
                next.PreviousNode = previous;
            }
            Size--;

            return true;
        }

        //Remove the last item in the linked list
        public T RemoveLast()
        {

           // bool status;
            if(Tall.Value == null)
            {
                return default(T);
            }
            
            Remove(Tall.Value); //Remove the last item in the list by pass the item in the tall
            return Tall.Value;
        }

        //Remove first item from linked list
        public T RemoveFisrtItem()
        {

            // bool status;
            if (Head.Value == null)
            {
                return default(T);
            }

            Remove(Head.Value); //Remove the first item in the list
            return Head.Value;
        }

        //Check if a value exist return true, else return false
        public bool Check(T userValue)
        {

            return Search(userValue) != null;
        }

        //Search for value in the linked list
        public TheNode<T> Search(T userValue)
        {
            //Search for a given value
            TheNode<T> currents = Head;  //initial the currents with the head
            ItemIndex = -1;

            while(currents != null)
            {
                ItemIndex++;
                if (currents.Value.Equals(userValue))
                {
                    
                    return currents;  //return current node if the value is found
                }
                
                currents = currents.PreviousNode; //Update currents with the next node
            }

            ItemIndex = -1; //When item is not found set index to -1
            return null; //Return null if the user input do not exist
        }

        //If the linked list empty
        public bool IsEmpty()
        {
            return Size == 0;
        }

        public int IndexItem()
        {
            return ItemIndex;
        }

        //Insert Item
        public void Insert(T value, int position)
        {
            if(position <= Size)
            {

                TheNode<T> currents = Head;  //initial the currents with the head
                
                var counter = 1;
                TheNode<T> newItem = new TheNode<T>(value);

                while (counter < position)
                {
                    
                    currents = currents.PreviousNode; //Update currents with the next node until counter equal position
                    
                    counter++;
                    
                }

                currents.NextNode.PreviousNode = newItem;
                newItem.PreviousNode = currents;
                newItem.NextNode = currents.NextNode;
                currents.NextNode = newItem;

                Console.WriteLine(value + " was inserted  successfully");
                

            }
            else
            {
                Console.WriteLine("Position should not be more than " + Size);
            }
            
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

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

       

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }
    }
}
