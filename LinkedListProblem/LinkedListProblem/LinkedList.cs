// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace LinkedListProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class LinkedList
    {
        /// <summary>
        /// Head node to mark the begining of the linked list
        /// </summary>
        public Node head;
        /// <summary>
        /// UC-1 Adding the node to the end of the linked list
        /// </summary>
        /// <param name="newData"></param>
        public void InsertEnd(int newData)
        {
            //Creating a new node with data passed to the node value
            Node newNode = new Node(newData);
            //If head is null i.e. end of linked list at the begining
            //Then initialising the head with the new node
            if(this.head == null)
            {
                this.head = newNode;
            }
            //Else- Get the last node by traversal
            //initialising the end oflast node with new node
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
            }
        }
        /// <summary>
        /// Getting the last node of the linked list by traversal
        /// </summary>
        /// <returns></returns>
        public Node GetLastNode()
        {
            //Initialising the head with a temporary node
            Node temp = this.head;
            //Iterating till the end of the linked list
            //Traversal by re-instantinating the temp to next node
            while(temp.next != null)
            {
                temp = temp.next;
            }
            //Returning the temp which is the last node
            return temp;
        }
        /// <summary>
        /// Displaying the linked list by traversal
        /// </summary>
        public void DisplayList()
        {
            //Initialising a temp node
            Node temp = this.head;
            //Limiting condition for empty Linked List 
            if(temp == null)
            {
                Console.WriteLine("The Linked List is Empty...");
                return;
            }
            //Traversal for displaying the element
            else
            {
                while(temp != null)
                {
                    Console.Write(temp.value + "  ");
                    temp = temp.next;
                }
            }
        }

    }
}
