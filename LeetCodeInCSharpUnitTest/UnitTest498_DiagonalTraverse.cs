using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest498_DiagonalTraverse
    {
        [TestMethod]
        public void TestMethodDiagonalTraverse()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 4, 7, 5, 3, 6, 8, 9 }, DiagonalTraverseSolution.FindDiagonalOrder(new int[,] {{1,2,3},{4,5,6},{7,8,9}}));
        }
    }
}
