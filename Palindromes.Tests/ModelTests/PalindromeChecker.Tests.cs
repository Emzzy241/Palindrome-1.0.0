using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;
using System.Collections.Generic;
using System;

namespace Palindromes.Tests
{
    [TestClass]
    public class MyPalindromesTests
    {
        [TestMethod]
        public void PalindromeConstructor_CreatesPalindromeInstance_Void()
        {
            PalindromeChecker newPalindrome = new PalindromeChecker();
            Assert.AreEqual(typeof(PalindromeChecker), newPalindrome.GetType());
        }
    }
}