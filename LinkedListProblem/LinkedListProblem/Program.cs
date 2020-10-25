// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace LinkedListProblem
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Welcome to Linked List Program");
            Console.WriteLine("==============================");
            //Creating the instance of the Linked List Class
            LinkedList newList = new LinkedList();
            //UC1- Adding to the linked list
            newList.Append(56);
            newList.Append(70);
            newList.InsertAtParticularPosition(2,30);
            Console.WriteLine("Linked List Status......");
            newList.DisplayList();
            //Searching a particular element in the linked list
            Console.WriteLine("\nPostion of the element 30 is  "+newList.SearchTheNode(30));
            int position = newList.SearchTheNode(30);
            //Inserting at the position prior to the position returned
            newList.InsertAtParticularPosition(position+1, 40);
            Console.WriteLine("Linked List Status......");
            newList.DisplayList();
            //Getting the count of the linked list
            Console.WriteLine("\nLinked List Element Count = "+newList.Count());
            //Deleting a particular internal node
            newList.DeleteParticularNode(30);
            newList.DisplayList();
            //Displaying the count after deletion
            Console.WriteLine("\nLinked List Element Count after the deletion of the node = " + newList.Count());
            //Calling the sorting function
            //Then displaying the list
            newList.SortingTheLinkedList();
            newList.DisplayList();
        }
    }
}
