using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort;
using System.Collections.Generic;

namespace TestProject
{
    [TestClass]
    public class SortingTest
    {
        [TestMethod]
        public void InsertionSortTest()
        {
            var unsortedList = new List<int>() { 3, 9, 7, 28, 8, 17 };
            var sortedList = new List<int>() { 3, 7, 8, 9, 17, 28 };
            SortingAlgorithms.InsertionSort(unsortedList);
            CollectionAssert.AreEqual(sortedList, unsortedList);
        }

        [TestMethod]
        public void BubbleSortTest()
        {
            var unsortedList = new List<int>() { 3, 9, 7, 28, 8, 17 };
            var sortedList = new List<int>() { 3, 7, 8, 9, 17, 28 };
            SortingAlgorithms.BubbleSort(unsortedList);
            CollectionAssert.AreEqual(sortedList, unsortedList);
        }

        [TestMethod]
        public void QuickSortTest()
        {
            var unsortedList = new List<int>() { 3, 9, 7, 28, 8, 17 };
            var sortedList = new List<int>() { 3, 7, 8, 9, 17, 28 };
            SortingAlgorithms.QuickSort(unsortedList);
            CollectionAssert.AreEqual(sortedList, unsortedList);
        }
    }
}
