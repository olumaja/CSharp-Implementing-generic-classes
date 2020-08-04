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

            Console.WriteLine("Welcome to my data structure");
            Console.WriteLine();
            Console.Write("Enter L to perform Linked List, Q to perform Queue or S to Stack data structure operation. Enter any other letter to terminate operation: ");


            do
            {
                userResponse = Console.ReadLine();
                Console.WriteLine();

                if (userResponse.ToLower() == "l")
                {
                    string userAnswer = "0";

                    do
                    {

                        if (userlistGui.EmptyStatus())
                        {
                            userlistGui.TailAdder();
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
                            else if (userAnswer != "y" && userAnswer != "q") { Console.WriteLine("Wrong choice! Try again"); }
                            else
                            {

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
                                else if (userAnswer == "5") { userlistGui.EmptyStatus(); }
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

                }
                else if (userResponse.ToLower() == "l")
                {

                }
                else
                {
                    userResponse = "t";
                }

                if(userResponse.ToLower() != "t") 
                {
                   
                        //To consider the codes
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

            //LinkedList<string> checkerList = new LinkedList<string>();
            
            ////Add method interface
            //string itemName;

            //do
            //{
            //    Console.Write("Enter any item to add into the linked list or press Q to stop adding: ");
            //    itemName = Console.ReadLine();
            //    Console.WriteLine();
            //    if(itemName.ToLower() != "q")
            //    {
            //        checkerList.Add(char.ToUpper(itemName[0]) + itemName.Substring(1));
            //        Console.WriteLine("The current size of LinkedList is {0}", checkerList.Size);
            //        Console.WriteLine();
            //    }  
                
            //} while (itemName.ToLower() != "q");

            ////The check interface
            //Console.Write("Enter a value to confirm if the value exist in the linked list ");
            //var toCheck = Console.ReadLine();
            //Console.WriteLine();
            //var confirmer = checkerList.Check(char.ToUpper(toCheck[0]) + toCheck.Substring(1));
            //Console.WriteLine(confirmer);

            ////Search interface
            //Console.Write("Do you want to search for an item? Enter Y for Yes or N for No: ");
            //var myInput = Console.ReadLine();
            //Console.WriteLine();            

            //do
            //{

            //    if(myInput.ToLower() == "y")
            //    {

            //        string tryAgain;

            //        do
            //        {

            //            Console.Write("Enter any value to search for an item in the linked list or press Q to qiut: ");
            //            var userInput = Console.ReadLine();
            //            Console.WriteLine();

            //            //If the user enter a value, then search for the value in the linked list
            //            if (userInput.ToLower() != "q")
            //            {
            //                var outCome = checkerList.Search(char.ToUpper(userInput[0]) + userInput.Substring(1));

            //                if (outCome != null)
            //                {
            //                    Console.WriteLine($"{outCome.Value} found, operation sucessful");
                               
            //                }

            //                else
            //                {
            //                    Console.WriteLine($"{userInput} is not in the linked list");
                                
            //                }                           

            //            }
            //            else
            //            {
            //                myInput = "q";
            //            }

            //            Console.Write("Do you want to perform another search? Enter Y for Yes or N for No: ");
            //            tryAgain = Console.ReadLine();
            //            Console.WriteLine();


            //        }while(tryAgain.ToLower() != "n");

            //        if(tryAgain.ToLower() == "n") { myInput = "q"; } //Terminate the search process
                   
            //    }
            //    else if(myInput.ToLower() == "n")
            //    {
            //        myInput = "q";
            //    }
            //    else
            //    {
            //        Console.Write("Wrong input, please Enter Y for Yes or N for No: ");
            //        myInput = Console.ReadLine();
            //        Console.WriteLine();
            //    }

            //} while (myInput.ToLower() != "q");



        }
    }
}
