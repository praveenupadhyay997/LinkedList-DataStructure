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
            newList.Append(56);
            newList.Append(70);
            newList.InsertAtParticularPosition(2,30);
            Console.WriteLine("Linked List Status......");
            newList.DisplayList();
            Console.WriteLine("\nPostion of the element 30 is  "+newList.SearchTheNode(30));
            int position = newList.SearchTheNode(30);
            newList.InsertAtParticularPosition(position+1, 40);
            Console.WriteLine("Linked List Status......");
            newList.DisplayList();
        }
    }
}
