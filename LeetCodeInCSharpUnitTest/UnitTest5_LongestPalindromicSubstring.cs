using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest5_LongestPalindromicSubstring
    {
        [TestMethod]
        public void T005__LongestPalindromicSubstring()
        {
            Assert.AreEqual("bab", LongestPalindromicSubstringSolution.LongestPalindrome("babad"));
            Assert.AreEqual("bb", LongestPalindromicSubstringSolution.LongestPalindrome("cbbd"));
            Assert.AreEqual("bbbbbbbb", LongestPalindromicSubstringSolution.LongestPalindrome("bbbbbbbb"));
            Assert.AreEqual("a", LongestPalindromicSubstringSolution.LongestPalindrome("abcda"));
            Assert.AreEqual("a", LongestPalindromicSubstringSolution.LongestPalindrome("a"));
        }
    }
}
