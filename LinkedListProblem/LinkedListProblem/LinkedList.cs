﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace LinkedListProblem
{
    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    public class LinkedList
    {
        /// <summary>
        /// Head node to mark the begining of the linked list
        /// </summary>
        public Node head;
        private Node tempNode;

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
        /// <summary>
        /// UC2- Inserting the element at the head of the linked list
        /// </summary>
        /// <param name="newData"></param>
        public void InsertInFront(int newData)
        {
            //Creating the instance of the new node
            Node newNode = new Node(newData);
            //Initialising the next new node to head position
            newNode.next = this.head;
            //Re-initialising the head position to new node
            this.head = newNode;
        }
        /// <summary>
        /// UC-3 Appending the node to the end of the linked list
        /// </summary>
        /// <param name="newData"></param>
        public void Append(int newData)
        {
            //Creating a new node with data passed to the node value
            Node newNode = new Node(newData);
            //If head is null i.e. end of linked list at the begining
            //Then initialising the head with the new node
            if (this.head == null)
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
        /// UC4- Inserting the node at a particular position in the linked list
        /// </summary>
        /// <param name="newData"></param>
        public Node InsertAtParticularPosition(int position, int newData)
        {
            //If the position is even not of the beginging then return an exception
            if (position < 1)
                Console.WriteLine("The Position passed is invalid to insert...");
            //If position is first appending at the begining of the linked list
            else if (position == 1)
            {
                Node newNode = new Node(newData);
                newNode.next = this.head;
                head = newNode;
            }
            //Iterating while decremention the position to keep track of the traversal
            else
            {
                //Assigning a temporary node the reference of the head node
                this.tempNode = this.head;
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        //Creating an instance of the new node
                        Node temp = new Node(newData);
                        //Adding the node to the next position of the node
                        temp.next = this.tempNode.next;
                        //Initialising the head to the temp node
                        tempNode.next = temp;
                        break;
                    }
                    // Incrementing the position of the node to next position
                    this.tempNode = this.tempNode.next;
                }
                if (position != 1)
                    Console.WriteLine("Position Out Of Range....");
            }
            Console.WriteLine("Inserted Value is - "+ newData);
            return head;   
        }
        /// <summary>
        /// UC5- Deleting the first node of the linked list
        /// </summary>
        /// <returns></returns>
        public Node DeleteFirstNode()
        {
            //Exception condition if the linked list is empty
            //else- repointing the head to second node
            if (this.head == null)
                return null;
            else
            {
                this.head = this.head.next;
                return this.head;
            }
        }
        /// <summary>
        /// UC6- Deleting the last node of the linked list
        /// </summary>
        /// <returns></returns>
        public Node DeleteLastNode()
        {
            //Exception cases when we have and empty linked list
            if (head == null)
                return null;
            //Exception case when we have only one node in the linked list
            if (head.next == null)
            {
                Console.WriteLine("Only one node in the linked list...");
            }
            //Creating a temporary node for traversal
            Node tempNode = this.head;
            //Traversing to the second last node
            while(tempNode.next.next != null)
            {
                tempNode = tempNode.next;
            }
            //Setting the next pointer to null thereby shorting the last node
            tempNode.next = null;
            return head;
        }
        /// <summary>
        /// UC7- Getting the position of the node with the value passed by the user
        /// </summary>
        /// <param name="valueOfNode"></param>
        /// <returns></returns>
        public int SearchTheNode(int valueOfNode)
        {
            this.tempNode = this.head;
            //Counter Variable
            int count = 0;
            //Iterating till the end of the linked list
            while(this.tempNode != null)
            {
                //Matching case of the data value of the node with the head value
                //Then returning the count and exiting the loop
                if (this.tempNode.value == valueOfNode)
                    return ++count;
                //Default cases to increment the node position in the loop
                this.tempNode = this.head.next;
                //Incrementing the counter variable
                count++;
            }
            return count;
        }
        /// <summary>
        /// Getting the Count of the Elements in the linked list
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            // Allocating a temporary node to the head of the linked list
            this.tempNode = this.head;
            int count = 0;
            while(this.tempNode != null)
            {
                ++count;
                this.tempNode = this.tempNode.next;
            }
            return count;
        }
        /// <summary>
        /// UC-9 Deleting a particular node in the linked list
        /// </summary>
        /// <param name="data"></param>
        public void DeleteParticularNode(int data)
        {
            // Allocating a temporary node to the head of the linked list
            this.tempNode = this.head;
            //Checking the condition till the end of the linked list
            while(tempNode.next != null)
            {
                //Matching the value with the value passed as the argument
                if (this.tempNode.next.value == data)
                {
                    //Shorting the current node to delete it
                    this.tempNode.next = this.tempNode.next.next;
                }
                //Moving to the next node
                this.tempNode = this.tempNode.next;
            }
        }
        /// <summary>
        /// UC10- Sorting the Linked List by using the algorithm of selection sort
        /// </summary>
        public  void SortingTheLinkedList()
        {
            //Allocating a temporary node to the head position
            this.tempNode = this.head;
            // Traverse the List till the list is null
            while (tempNode !=null)
            {
                //Allocating the minimum value to the current node
                Node getMinimumValue = tempNode;
                //Defining the unsorted list from the next position till the last node
                Node unsortedList = tempNode.next;
                // Traverse the unsorted list till the last node is reached
                while (unsortedList != null)
                {
                    //Logic to chek whether the reached value is greater or small
                    //Then restoring the position of the minimum node to the unsorted list current position
                    if (getMinimumValue.value > unsortedList.value)
                        getMinimumValue = unsortedList;
                    //Moving to the next position in the unsorted linked list
                    unsortedList = unsortedList.next;
                }
                // Swapping the Data by using a non generic temporary variable
                int localTempValue = tempNode.value;
                tempNode.value = getMinimumValue.value;
                getMinimumValue.value = localTempValue;
                //Moving to the next node
                this.tempNode = this.tempNode.next;
            }
        }
    }
}
