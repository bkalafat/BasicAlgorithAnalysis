using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;
using Selection;

namespace TestProject
{
    [TestClass]
    public class ProblemTest
    {
        [TestMethod]
        public void MedianTest()
        {
            var median = new Median();

            median.AddNumber(0);
            median.AddNumber(1);
            median.AddNumber(2);
            median.AddNumber(4);
            median.AddNumber(6);
            median.AddNumber(5);
            median.AddNumber(3);


            var calculatedMedian = median.GetMedian();
            Assert.AreEqual(3, calculatedMedian);
        }

        [TestMethod]
        public void QuickSelectTest()
        {
            var unsortedList = new List<int> { 3, 9, 7, 28, 8, 17 };

            var result = QuickSelect.Find(unsortedList,6);

            Assert.AreEqual(28, result);
        }

        [TestMethod]
        public void QuickSelectTestSecondSeven()
        {
            List<int> unsortedList = new() { 3, 9, 7, 28, 8, 17 };

            var result = QuickSelect.Find(unsortedList,2);

            Assert.AreEqual(7, result);
        }
    }
}