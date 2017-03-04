﻿using Algorithm.Sandbox.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Algorithm.Sandbox.Tests.Sorting
{
    [TestClass]
    public class Sort_Tests
    {
        private static int[] TestArray = new int[] { 7, 8, 3, 2, 1, 5, 4, 6, 0 };

        /// <summary>
        /// </summary>
        [TestMethod]
        public void BubbleSort_Test()
        {
            var rnd = new Random();
            var nodeCount = 1000;
            var randomNumbers = Enumerable.Range(1, nodeCount)
                                .OrderBy(x => rnd.Next())
                                .ToList();

            var result = BubbleSort<int>.Sort(randomNumbers.ToArray());

            for (int i = 1; i <= nodeCount; i++)
            {
                Assert.AreEqual(i, result[i-1]);
            }
        }


        /// <summary>
        /// </summary>
        [TestMethod]
        public void SelectionSort_Test()
        {
            var result = SelectionSort<int>.Sort(TestArray);

            for (int i = 0; i <= 8; i++)
            {
                Assert.AreEqual(i, result[i]);
            }
        }

        /// <summary>
        /// </summary>
        [TestMethod]
        public void InsertionSort_Test()
        {
            var result = InsertionSort<int>.Sort(TestArray);

            for (int i = 0; i <= 8; i++)
            {
                Assert.AreEqual(i, result[i]);
            }
        }

        /// <summary>
        /// </summary>
        [TestMethod]
        public void QuickSort_Test()
        {
            var result = QuickSort<int>.Sort(TestArray);

            for (int i = 0; i <= 8; i++)
            {
                Assert.AreEqual(i, result[i]);
            }
        }

        /// <summary>
        /// </summary>
        [TestMethod]
        public void MergeSort_Test()
        {
            var result = MergeSort<int>.Sort(TestArray);

            for (int i = 0; i <= 8; i++)
            {
                Assert.AreEqual(i, result[i]);
            }
        }

        /// <summary>
        /// </summary>
        [TestMethod]
        public void HeapSort_Test()
        {
            var result = HeapSort<int>.Sort(TestArray);

            for (int i = 0; i <= 8; i++)
            {
                Assert.AreEqual(i, result[i]);
            }
        }

        /// <summary>
        /// </summary>
        [TestMethod]
        public void TreeSort_Test()
        {
            var result = TreeSort<int>.Sort(TestArray);

            for (int i = 0; i <= 8; i++)
            {
                Assert.AreEqual(i, result[i]);
            }
        }
    }
}
