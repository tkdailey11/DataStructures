using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace DoublyLinkedListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddFirst1()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.addFirst(3);
            Assert.AreEqual(1, list.size);

            list.addFirst(2);
            Assert.AreEqual(2, list.size);
            Assert.AreEqual(2, list.get(0));
            Assert.AreEqual(3, list.get(1));

            list.addFirst(1);
            Assert.AreEqual(3, list.size);
            Assert.AreEqual(1, list.get(0));
            Assert.AreEqual(2, list.get(1));
            Assert.AreEqual(3, list.get(2));
        }


        [TestMethod]
        public void TestAddLast1()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.addLast(3);
            Assert.AreEqual(1, list.size);

            list.addLast(2);
            Assert.AreEqual(2, list.size);
            Assert.AreEqual(2, list.get(1));
            Assert.AreEqual(3, list.get(0));

            list.addLast(1);
            Assert.AreEqual(3, list.size);
            Assert.AreEqual(1, list.get(2));
            Assert.AreEqual(2, list.get(1));
            Assert.AreEqual(3, list.get(0));
        }


        [TestMethod]
        public void TestAdd1()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.add(1, 0);
            list.add(4, 1);
            Assert.AreEqual(2, list.size);
            Assert.AreEqual(1, list.get(0));
            Assert.AreEqual(4, list.get(1));
        }


        [TestMethod]
        public void TestAdd2()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.add(1, 0);
            list.add(4, 1);

            list.add(2, 1);
            list.add(3, 2);

            Assert.AreEqual(4, list.size);
            Assert.AreEqual(1, list.get(0));
            Assert.AreEqual(2, list.get(1));
            Assert.AreEqual(3, list.get(2));
            Assert.AreEqual(4, list.get(3));
        }


        [TestMethod]
        public void TestRemoveFirst1()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.add(1, 0);
            list.add(4, 1);
            list.add(2, 1);
            list.add(3, 2);
            Assert.AreEqual(4, list.size);
            Assert.AreEqual(1, list.get(0));

            list.removeFirst();
            Assert.AreEqual(3, list.size);
            Assert.AreEqual(2, list.get(0));

            list.removeFirst();
            Assert.AreEqual(2, list.size);
            Assert.AreEqual(3, list.get(0));

            list.removeFirst();
            Assert.AreEqual(1, list.size);
            Assert.AreEqual(4, list.get(0));

            list.removeFirst();
            Assert.AreEqual(0, list.size);
        }


        [TestMethod]
        public void TestRemoveLast1()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.add(1, 0);
            list.add(4, 1);
            list.add(2, 1);
            list.add(3, 2);
            Assert.AreEqual(4, list.size);
            Assert.AreEqual(1, list.get(0));

            list.removeLast();
            Assert.AreEqual(3, list.size);
            Assert.AreEqual(3, list.get(list.size - 1));

            list.removeLast();
            Assert.AreEqual(2, list.size);
            Assert.AreEqual(2, list.get(list.size - 1));

            list.removeLast();
            Assert.AreEqual(1, list.size);
            Assert.AreEqual(1, list.get(list.size - 1));

            list.removeLast();
            Assert.AreEqual(0, list.size);
        }


        [TestMethod]
        public void TestRemoveAt1()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.add(1, 0);
            list.add(4, 1);
            list.add(2, 1);
            list.add(3, 2);

            list.removeAt(1);
            Assert.AreEqual(3, list.size);
            Assert.AreEqual(1, list.get(0));
            Assert.AreEqual(3, list.get(1));
            Assert.AreEqual(4, list.get(2));

            list.removeAt(2);
            Assert.AreEqual(2, list.size);
            Assert.AreEqual(1, list.get(0));
            Assert.AreEqual(3, list.get(1));

        }
    }
}
