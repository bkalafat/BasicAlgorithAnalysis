using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace TestProject
{
    [TestClass]
    public class ProblemTest
    {
        [TestMethod]
        public void MedianTest()
        {
            Median median = new Median();

            median.AddNumber(0);
            median.AddNumber(1);
            median.AddNumber(2);
            median.AddNumber(4);
            median.AddNumber(6);
            median.AddNumber(5);
            median.AddNumber(3);


            double calculatedMedian = median.GetMedian();
            Assert.AreEqual(3, calculatedMedian);
        }
    }
}