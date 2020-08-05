using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplexDataStructures.Datalib
{
    class LinkedListGUI
    {

        LinkedList<string> checkerList = new LinkedList<string>();

        public void HeadAdder()
        {
            //AddHead method interface
           
                Console.Write("Enter any item to add into the linked list: ");
                string itemName = Console.ReadLine();
                Console.WriteLine();
               
                checkerList.AddHead(char.ToUpper(itemName[0]) + itemName.Substring(1).ToLower());
                Console.WriteLine("The current size of LinkedList is {0}", checkerList.Size);
                Console.WriteLine();
             
        }

        public void TailAdder()
        {
            //AddTail method interface

            Console.Write("Enter any item to add into the linked list: ");
            string itemName = Console.ReadLine();
            Console.WriteLine();

            checkerList.AddTail(char.ToUpper(itemName[0]) + itemName.Substring(1).ToLower());
            Console.WriteLine(char.ToUpper(itemName[0]) + itemName.Substring(1).ToLower() + " was add to the list");
            Console.WriteLine();
            Console.WriteLine("The current size of LinkedList is {0}", checkerList.Size);
            Console.WriteLine();

        }

        public void Remover()
        {
            //Remove method interface
            Console.Write("Enter item to remove: ");
            var userValue = Console.ReadLine();
            Console.WriteLine();
            checkerList.Remove(char.ToUpper(userValue[0]) + userValue.Substring(1).ToLower());
            Console.WriteLine(char.ToUpper(userValue[0]) + userValue.Substring(1).ToLower() + " was remove from the list");
            Console.WriteLine("The current size of LinkedList is {0}", checkerList.Size);
            Console.WriteLine();

        }

        public void RemoverLast()
        {
            //Remove last method interface
            checkerList.RemoveLast();
            Console.WriteLine("The current size of LinkedList is {0}", checkerList.Size);
        }

        public void Check()
        {

            //The check interface
            Console.Write("Enter a value to confirm if the value exist in the linked list: ");
            var toCheck = Console.ReadLine();
            Console.WriteLine();
            var confirmer = checkerList.Check(char.ToUpper(toCheck[0]) + toCheck.Substring(1).ToLower());
            Console.WriteLine(confirmer);

        }

        public void Search()
        {

            Console.Write("Enter item into the linked list: ");
            var userInput = Console.ReadLine();
            Console.WriteLine();
            var outCome = checkerList.Search(char.ToUpper(userInput[0]) + userInput.Substring(1).ToLower());

            if (outCome != null)
            {
               Console.WriteLine($"{outCome.Value} found, operation sucessful");

            }

            else
            {
              Console.WriteLine($"{userInput} is not in the linked list");

            }

        }

        //Insert an item at a given position
        public void InsertItem()
        {
            Console.Write("Enter the item to insert: ");
            var item = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the position (number) that the item will be inserted: ");
            var position = Console.ReadLine();
            Console.WriteLine();
            checkerList.Insert(item, Convert.ToInt32(position));

        }

        //Display the Item index
        public void IndexItemFinder()
        {
            Console.WriteLine("To get item index");
            Console.WriteLine();
            Search();
            Console.WriteLine("At index " + checkerList.IndexItem());
        }

        //Empty tester method
        public bool EmptyStatus()
        {
            return checkerList.IsEmpty();
        }

        //List Size
        public void SizeOfList()
        {
            Console.WriteLine("The linked list size is " + checkerList.Size);
            Console.WriteLine();
        }

    }
}
