using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLab_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = new int[] { 20, 5, 8, 2, 365, 108 };
            int[] arrSorted = new int[] { 2, 5, 8, 20, 108, 365 };
            Array.Sort(arr);
            CollectionAssert.AreEqual(arrSorted, arr);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] arr = new int[] { 20, 5, 8, 2, 365, -108 };
            int[] arrSorted = new int[] { -108, 2, 5, 8, 20, 365 };
            Array.Sort(arr);
            CollectionAssert.AreEqual(arrSorted, arr);
        }

    }
}
