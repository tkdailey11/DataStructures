using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace SinglyLinkedListTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestCreateNew()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            Assert.AreEqual(0, list.size);
        }


        [TestMethod]
        public void TestSizeAddFirstToEmptyList()
        {
            try
            {
                SinglyLinkedList<int> list = new SinglyLinkedList<int>();
                list.addFirst(0);
                Assert.AreEqual(1, list.size);
            }
            catch
            {
                Assert.Fail();
            }
            
        }

        [TestMethod]
        public void TestSizeAddLast()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.addLast(0);
            Assert.AreEqual(1, list.size);

            list.addLast(1);
            Assert.AreEqual(2, list.size);

        }


        [TestMethod]
        public void TestAddFirst()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.addFirst(1);
            Assert.AreEqual(1, list.get(0));

            list.addFirst(2);
            Assert.AreEqual(2, list.get(0));
            Assert.AreEqual(1, list.get(1));

            list.addFirst(3);
            Assert.AreEqual(3, list.get(0));
            Assert.AreEqual(2, list.get(1));
            Assert.AreEqual(1, list.get(2));
        }


        [TestMethod]
        public void TestAddLast()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.addLast(1);
            Assert.AreEqual(1, list.get(0));

            list.addLast(2);
            Assert.AreEqual(2, list.get(1));
            Assert.AreEqual(1, list.get(0));

            list.addLast(3);
            Assert.AreEqual(3, list.get(2));
            Assert.AreEqual(2, list.get(1));
            Assert.AreEqual(1, list.get(0));
        }


        [TestMethod]
        public void TestGet()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.addLast(0);
            Assert.AreEqual(0, list.get(0));

            list.addLast(1);
            Assert.AreEqual(1, list.get(1));
        }


        [TestMethod]
        public void TestGetInvalid1()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();

            try
            {
                list.get(0);
                Assert.Fail();
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }


        [TestMethod]
        public void TestGetInvalidNegative()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.addLast(1);

            try
            {
                list.get(-1);
                Assert.Fail();
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }


        [TestMethod]
        public void TestGetInvalidLarge()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.addLast(1);

            try
            {
                list.get(1);
                Assert.Fail();
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void TestRemoveFirstValid1()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.addFirst(1);

            Assert.AreEqual(1, list.size);

            list.removeFirst();
            Assert.AreEqual(0, list.size);
            list.removeFirst();
            Assert.AreEqual(0, list.size);
        }

        [TestMethod]
        public void TestRemoveLastValid1()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.addFirst(1);

            Assert.AreEqual(1, list.size);

            list.removeLast();
            Assert.AreEqual(0, list.size);
            list.removeLast();
            Assert.AreEqual(0, list.size);
        }


        [TestMethod]
        public void TestRemoveFirstValid2()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.addFirst(1);

            Assert.AreEqual(1, list.size);

            list.removeFirst();
            Assert.AreEqual(0, list.size);
            list.removeFirst();
            Assert.AreEqual(0, list.size);
        }

        [TestMethod]
        public void TestRemoveLastValid2()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.addFirst(1);

            Assert.AreEqual(1, list.size);

            list.removeLast();
            Assert.AreEqual(0, list.size);
            list.removeLast();
            Assert.AreEqual(0, list.size);
        }


        [TestMethod]
        public void TestAdd1()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.add(2, 0);
            list.add(8, 1);
            list.add(1, 0);
            list.add(4, 2);

            Assert.AreEqual(4, list.size);
            Assert.AreEqual(1, list.get(0));
            Assert.AreEqual(2, list.get(1));
            Assert.AreEqual(4, list.get(2));
            Assert.AreEqual(8, list.get(3));


        }

        [TestMethod]
        public void TestWithStrings()
        {
            SinglyLinkedList<string> list = new SinglyLinkedList<string>();
            Assert.AreEqual(0, list.size);

            list.addFirst("First");
            list.addLast("Last");
            Assert.AreEqual(2, list.size);

            list.add("Middle", 1);
            Assert.AreEqual(3, list.size);

            Assert.AreEqual("First", list.get(0));
            Assert.AreEqual("Middle", list.get(1));
            Assert.AreEqual("Last", list.get(2));
        }
    }
}
