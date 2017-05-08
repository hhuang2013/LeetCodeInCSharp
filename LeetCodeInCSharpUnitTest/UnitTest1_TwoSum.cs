using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest1_TwoSum
    {
        [TestMethod]
        public void TestMethodTwoSum()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2 },TwoSumSolution.TwoSum(new int[] {3,2,4},6));
        }
    }
}
