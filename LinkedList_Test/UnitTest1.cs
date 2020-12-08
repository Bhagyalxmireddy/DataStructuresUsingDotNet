using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data_Structure_Problem;
using System;

namespace LinkedList_Test
{
    [TestClass]
    public class UnitTest1
    {
        LinkedList linkedList;

        public UnitTest1()
        {
            linkedList = new LinkedList(); 
        }

        [TestMethod]
        public void given3Numbers_WhenAddedToTheLinkedList_ShouldBeAddedToTheTop()
        {
            int firstElement = 70;
            int secondElement = 30;
            int thirdElement = 56;
            linkedList.Add(70);
            linkedList.Add(30);
            linkedList.Add(56);
            int Node1 = linkedList.CheckFirstElement();
            int Node2 = linkedList.CheckMiddleElement();
            int Node3 = linkedList.CheckLastElement();
            bool result = Node1.Equals(thirdElement) && Node2.Equals(secondElement) && Node3.Equals(firstElement);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void given3Numbers_WhenAppended_ShouldBeAddedToLast()
        {

            int firstElement = 70;
            int secondElement = 30;
            int thirdElement = 56;
            linkedList.Append(70);
            linkedList.Append(30);
            linkedList.Append(56);
            int Node1 = linkedList.CheckFirstElement();
            int Node2 = linkedList.CheckMiddleElement();
            int Node3 = linkedList.CheckLastElement();
            bool result = Node1.Equals(firstElement) && Node2.Equals(secondElement) && Node3.Equals(thirdElement);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void given3Numbers_InsertingtheElementInBetween_ShouldBeAdded()
        {
            int firstElement = 70;
            int secondElement = 30;
            int thirdElement = 56;

            linkedList.Append(firstElement);
            linkedList.Append(thirdElement);
            linkedList.Insert(2, secondElement);

            int Node2 = linkedList.CheckMiddleElement();
            bool result = secondElement.Equals(Node2);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void givenFirstElement_WhenDeleted_shouldReturnTrue()
        {
            int firstElement = 70;
            int secondElement = 30;
            int thirdElement = 56;
            linkedList.Append(70);
            linkedList.Append(30);
            linkedList.Append(56);
            linkedList.pop();

            int Node1 = linkedList.CheckFirstElement();
            bool result = Node1.Equals(secondElement);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void givenLastElement_WhenDeleted_ShouldReturnTure()
        {
            int firstElement = 70;
            int secondElement = 30;
            int thirdElement = 56;
            linkedList.Append(firstElement);
            linkedList.Append(secondElement);
            linkedList.Append(thirdElement);
            linkedList.popLast();

            int tail = linkedList.CheckLastElement();
            bool reult = tail.Equals(secondElement);
            Assert.IsTrue(reult);
        }
        [TestMethod]
        public void givenKey_WhenSearchInTheList_ShouldReturnTure()
        {
            int firstElement = 70;
            int secondElement = 30;
            int thirdElement = 56;
            linkedList.Append(firstElement);
            linkedList.Append(secondElement);
            linkedList.Append(thirdElement);

            int searchKey = linkedList.Search(secondElement);
            Assert.AreEqual(searchKey, secondElement);          
        }
        [TestMethod]
        public void givenElement_NeedToInsertInthelist_searchWithKey()
        {
            int firstElement = 70;
            int secondElement = 30;
            int thirdElement = 56;

            linkedList.Append(firstElement);
            linkedList.Append(thirdElement);
            linkedList.Insert(2, 30);

            int searchkey = linkedList.Search(secondElement);
            Assert.AreEqual(searchkey, secondElement);
        }
        [TestMethod]
        public void givenElements_WhenInsertedAnddelete_AndReturnTheSize()
        {
            int firstElement = 70;
            int secondElement = 30;
            int thirdElement = 40;
            int fourtElement = 56;

            linkedList.Append(firstElement);
            linkedList.Append(secondElement);
            linkedList.Append(fourtElement);
            linkedList.Insert(4, thirdElement);
            linkedList.RemoveElemet(thirdElement);
            int size = linkedList.sizeOfList();
            Assert.AreEqual(3, size);
        }
    }
}
