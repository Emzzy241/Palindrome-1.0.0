using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;
using System.Collections.Generic;
using System;

namespace Palindromes.Tests
{
    [TestClass]
    public class MyPalindromesTests
    {
        // 1st Test: Test to create an instance of the PalindromeChecker
        [TestMethod]
        public void PalindromeConstructor_CreatesPalindromeInstance_Void()
        {
            PalindromeChecker newPalindrome = new PalindromeChecker("level");
            Assert.AreEqual(typeof(PalindromeChecker), newPalindrome.GetType());
        }

        // 2nd Test: Getting the word that would be checked if its a palindrome
        [TestMethod]
        public void GetName_GetsNameInputted_String()
        {
            // Arrange
            PalindromeChecker newPalindrome = new PalindromeChecker("hello");
            string expectedPalWord = "hello";

            // Act
            string returnedPalWord = newPalindrome.PalindromeWord;

            // Assert
            Assert.AreEqual(expectedPalWord, returnedPalWord);
        }
       
        // 3rd Test: Setting the word
        [TestMethod]
        public void SetName_SetsNameInputted_String()
        {
            // Arrange
            PalindromeChecker newPalindrome = new PalindromeChecker("hello");
            string expectedPalWord = "toward";

            // Act
            newPalindrome.PalindromeWord = "toward";

            // Assert
            Assert.AreEqual(expectedPalWord, newPalindrome.PalindromeWord);
        }

        // 4th Test: Convert String to characters Method
        // [TestMethod]
        // public void ConvertStringToCharArray_ConvertsStringsTOArrayAndStore_Array()
        // {
        //     // Arrange
        //     PalindromeChecker newPalindrome = new PalindromeChecker("hello");
        //     string wordToConvert = "level";

        //     // Act
        //     char[] expectedCharArray = { 'l', 'e', 'v', 'e', 'l'};
        //     string expectedString = expectedCharArray.ToString();
        //     string returnedCharArray = newPalindrome.ConvertStrToCharArray(wordToConvert);
        
        //     // Assert
        //     Assert.AreEqual(expectedString, returnedCharArray);
        // }

    //      [TestMethod]
    // public void GetArray_DisplayInputedName()
    // {
    //   Reverse testReverse = new Reverse();
    //   Assert.AreEqual("hannah", testReverse.GetArray("hannah"));
    // }


    }
}