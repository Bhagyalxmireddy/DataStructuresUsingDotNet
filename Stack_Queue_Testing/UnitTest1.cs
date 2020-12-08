using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data_Structure_Problem;

namespace Stack_Queue_Testing
{
    [TestClass]
    public class UnitTest1
    {
        Stack stack = new Stack();
        Queue queue = new Queue();

        [TestMethod]
        public void gievnElemenst_PushToTheStack()
        {
            int firstElement = 70;
            int secondElement = 30;
            int thirdElement = 56;

            stack.PushElements(firstElement);
            stack.PushElements(secondElement);
            stack.PushElements(thirdElement);
            int peek = stack.peek();
            Assert.AreEqual(peek, thirdElement);
        }
        [TestMethod]
        public void givenElement_PopFromTheStack()
        {
            int firstElement = 70;
            int secondElement = 30;
            int thirdElement = 56;

            stack.PushElements(firstElement);
            stack.PushElements(secondElement);
            stack.PushElements(thirdElement);
            stack.pop();
            int peek = stack.peek();
            Assert.AreEqual(peek, secondElement);
        }
        [TestMethod]
        public void givenElement_CheckingFortheEmpty()
        {
            int firstElement = 70;
            int secondElement = 30;
            int thirdElement = 56;

            stack.PushElements(firstElement);
            stack.PushElements(secondElement);
            stack.PushElements(thirdElement);
            stack.Empty_TheStack();
            int size = stack.size();
            Assert.AreEqual(0, size);
        }
        [TestMethod]
        public void givenElement_CheckingTheStackIsEmpty()
        {
            int firstElement = 70;
            int secondElement = 30;
            int thirdElement = 56;

            stack.PushElements(firstElement);
            stack.PushElements(secondElement);
            stack.PushElements(thirdElement);
            stack.Empty_TheStack();
            bool result = stack.Is_Empty();
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void givenElements_AddingElementsToTheQueue()
        {
            int firstElement = 70;
            int secondElement = 30;
            int thirdElement = 56;

            queue.Enqueue(firstElement);
            queue.Enqueue(secondElement);
            queue.Enqueue(thirdElement);
            queue.Dequeue();
            bool result = queue.IsEmpty();
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void givenElement_SizeOfQueue()
        {
            int firstElement = 70;
            int secondElement = 30;
            int thirdElement = 56;

            queue.Enqueue(firstElement);
            queue.Enqueue(secondElement);
            queue.Enqueue(thirdElement);
            queue.Dequeue();
            int size = queue.Size();
            Assert.AreEqual(3, size);
        }
    }
}
