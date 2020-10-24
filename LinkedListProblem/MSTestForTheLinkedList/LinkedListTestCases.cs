// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedListTestCases.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace MSTestForTheLinkedList
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using LinkedListProblem;
    [TestClass]
    public class LinkedListTestCases
    {
        /// <summary>
        /// Testing the Position of the node of the linked list
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position"></param>
        [DataRow(30, 2)]
        [TestCategory("Testing the position of the node")]
        [TestMethod]
        public void TestForPositionInTheLinkedList(int value, int position)
        {
            //Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.InsertInFront(56);
            linkedList.InsertEnd(70);
            linkedList.InsertAtParticularPosition(2, 30);
            //Act
            int expected = 2;
            int actual = linkedList.SearchTheNode(30);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
