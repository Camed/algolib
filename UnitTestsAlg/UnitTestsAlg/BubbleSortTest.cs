using System;
using AlgoLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsAlg
{
    [TestClass]
    public class BubbleSortTest
    {
        [TestMethod]
        public void TestSort()
        {
            BubbleSort<int> b = new BubbleSort<int>();
            Node<int>[] node = { new Node<int>(10), new Node<int>(7) };
            node = b.Sort(node);
            Assert.AreEqual(7, node[0].Value);
            Assert.AreEqual(10, node[0].Value);
        }

        [TestMethod]
        public void TestReverseSort()
        {
            BubbleSort<int> b = new BubbleSort<int>();
            Node<int>[] node = { new Node<int>(7), new Node<int>(10) };
            node = b.ReverseSort(node);
            Assert.AreEqual(10, node[0].Value);
            Assert.AreEqual(7, node[0].Value);
        }
    }
}
