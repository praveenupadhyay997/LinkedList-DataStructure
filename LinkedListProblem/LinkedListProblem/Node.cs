// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Node.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace LinkedListProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Class intended to initialise an instance of the node containing value and address of next node
    /// </summary>
    public class Node
    {
        public int value;
        public Node next;
        //PArameterised constuctor initialising the value of the node
        public Node(int value)
        {
            this.value = value;
        }
    }
}
