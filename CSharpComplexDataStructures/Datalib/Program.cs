using CSharpComplexDataStructures.Datalib;
using System;
using System.Collections.Generic;

namespace CSharpComplexDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            string userResponse;
            LinkedListGUI userlistGui = new LinkedListGUI();
            StackGUI guiForStack = new StackGUI();
            GenericQueue queueGUI = new GenericQueue();

            Console.WriteLine("Welcome to my data structure");
            Console.WriteLine();
            Console.Write("Enter L to perform Linked List, Q to perform Queue or S to Stack data structure operation. Enter any other letter to terminate operation: ");


            do
            {
                userResponse = Console.ReadLine();
                Console.WriteLine();

                if (userResponse.ToLower() == "l")
                {
                    string userAnswer = "";

                    do
                    {
                        //Check if list is empty
                        if (userlistGui.EmptyStatus())
                        {
                            userlistGui.TailAdder(); //Must add item before performing any linked list operation
                        }
                        else
                        {
                            Console.Write("Do you want to perform more linked list operation, enter Y for Yes or Q for quit: ");
                            userAnswer = Console.ReadLine();
                            Console.WriteLine();
                            if(userAnswer.ToLower() == "q") 
                            {
                                userAnswer = "9"; 
                            }
                            else if (userAnswer.ToLower() != "y" && userAnswer.ToLower() != "q") { Console.WriteLine("Wrong choice! Try again"); }
                            else
                            {
                                //User prompt GUI                              
                                Console.WriteLine("Enter 1: to Add item to linked list");
                                Console.WriteLine("Enter 2: to Remove item from linked list");
                                Console.WriteLine("Enter 3: to Check item from linked list");
                                Console.WriteLine("Enter 4: to Search item from linked list");
                                Console.WriteLine("Enter 5: to confirm if linked list Empty");
                                Console.WriteLine("Enter 6: to know linked list Size");
                                Console.WriteLine("Enter 7: to Insert item to linked list");
                                Console.WriteLine("Enter 8: to display Index of an item in linked list");
                                Console.WriteLine("Enter 9: to quit");
                                userAnswer = Console.ReadLine();
                                Console.WriteLine();

                                if (userAnswer == "1") { userlistGui.TailAdder(); }
                                else if (userAnswer == "2") { userlistGui.Remover(); }
                                else if (userAnswer == "3") { userlistGui.Check(); }
                                else if (userAnswer == "4") { userlistGui.Search(); }
                                else if (userAnswer == "5") { Console.WriteLine(userlistGui.EmptyStatus()); Console.WriteLine(); }
                                else if (userAnswer == "6") { userlistGui.SizeOfList(); }
                                else if (userAnswer == "7") { userlistGui.InsertItem(); }
                                else if (userAnswer == "8") { userlistGui.IndexItemFinder(); }
                                else if (userAnswer != "9") { Console.WriteLine("Wrong choice! try again: "); }

                            }


                        }

                    } while (userAnswer != "9");

                }
                else if (userResponse.ToLower() == "q")
                {
                    string userQueue = "";

                    do
                    {
                        if (queueGUI.IsEmpty())
                        {
                            queueGUI.Enqueue();
                        }
                        else
                        {

                            Console.Write("Do you want to perform more queue operation, enter Y for Yes or Q for quit: ");
                            userQueue = Console.ReadLine();
                            Console.WriteLine();
                            if (userQueue.ToLower() == "q") { userQueue = "6"; }
                            else if (userQueue.ToLower() != "y" && userQueue.ToLower() != "q") { Console.WriteLine("Wrong choice! Try again"); }
                            else
                            {

                                //User prompt GUI for queue
                                Console.WriteLine("Enter 1: to Enqueue item into queue");
                                Console.WriteLine("Enter 2: to Dequeue item from queue");
                                Console.WriteLine("Enter 3: to check if queue IsEmpty");
                                Console.WriteLine("Enter 4: to display queue length");
                                Console.WriteLine("Enter 5: to print latest operation");
                                Console.WriteLine("Enter 6: to quit");
                                userQueue = Console.ReadLine();
                                Console.WriteLine();
                                if (userQueue == "1") { queueGUI.Enqueue(); }
                                else if (userQueue == "2") { queueGUI.Dequeue(); }
                                else if (userQueue == "3") { Console.WriteLine(queueGUI.IsEmpty()); Console.WriteLine(); }
                                else if (userQueue == "4") { queueGUI.Sizes(); }
                                else if (userQueue == "5") { queueGUI.Print(); }
                                else if (userQueue != "6") { Console.WriteLine("Wrong choice! try again: "); }

                            }

                        }


                    } while (userQueue != "6");


                }
                else if (userResponse.ToLower() == "s")
                {
                    string inputUser = "";

                    do
                    {

                        if (guiForStack.IsEmpty())
                        {
                            guiForStack.Push();
                        }
                        else
                        {
                            Console.Write("Do you want to perform more stack operation, enter Y for Yes or Q for quit: ");
                            inputUser = Console.ReadLine();
                            Console.WriteLine();
                            if(inputUser.ToLower() == "q") { inputUser = "7";}
                            else if (inputUser.ToLower() != "y" && inputUser.ToLower() != "q") { Console.WriteLine("Wrong choice! Try again"); }
                            else
                            {
                                //User prompt GUI
                                Console.WriteLine("Enter 1: to Push item into stack");                               
                                Console.WriteLine("Enter 2: to Pop item from stack");
                                Console.WriteLine("Enter 3: to check if stack IsEmpty");
                                Console.WriteLine("Enter 4: to Peek stack");
                                Console.WriteLine("Enter 5: to confirm size of the stack");
                                Console.WriteLine("Enter 6: to Print latest operation");
                                Console.WriteLine("Enter 7: to quit");
                                inputUser = Console.ReadLine();
                                Console.WriteLine();
                                if (inputUser == "1") { guiForStack.Push(); }
                                else if (inputUser == "2") { guiForStack.Pop(); }
                                else if (inputUser == "3") { Console.WriteLine(guiForStack.IsEmpty()); Console.WriteLine(); }
                                else if (inputUser == "4") { Console.WriteLine("The last item in the stack is " + guiForStack.Peek()); }
                                else if (inputUser == "5") { guiForStack.Sizes(); }
                                else if (inputUser == "6") { guiForStack.Print(); }
                                else if (inputUser != "7") { Console.WriteLine("Wrong choice! try again: "); }                               

                            }

                        }

                    }while(inputUser != "7");

                }
                else
                {
                    userResponse = "t";
                }

                if(userResponse.ToLower() != "t") 
                {
                   
                        //The conditions in the codes below decide if the do-while will continue or terminate
                        Console.Write("Do you want to perform another data structure operation? Enter Y for Yes or N for No: ");
                        var anotherOperation = Console.ReadLine();
                        Console.WriteLine();
                        if (anotherOperation.ToLower() == "y")
                        {
                            Console.Write("Enter L to perform Linked List, Q to perform Queue or S to Stack data structure operation. Enter any other letter to terminate operation: ");
                        }
                        else if (anotherOperation.ToLower() == "n") { userResponse = "t"; }
                        else {
                            Console.WriteLine("Wrong choice, try again"); 
                        }

                    
                }

            } while (userResponse != "t");

        }
    }
}
