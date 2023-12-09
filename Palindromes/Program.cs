using System;
using Palindromes.Models;
using System.Collections.Generic;

namespace Palindromes.Models
{
    public class MyPalindromes
    {
        static void Main()
        {
            Console.WriteLine();
            Console.WriteLine("Palindrome Checker");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter your word: ");
            string inputWord = Console.ReadLine().ToLower();
            Console.WriteLine();
            PalindromeChecker Word = new PalindromeChecker(inputWord);
            Console.WriteLine();
            Console.WriteLine("Your Word backwards: " + Word.ConvertStrToCharArray());
            Console.WriteLine(Word.ResultDeterminer());

            Console.WriteLine("To enter another word, enter 'y' for yes or 'n'");
            string userContinue = Console.ReadLine().ToLower();
            Console.WriteLine();

            if(userContinue == "y")
            {
                Console.WriteLine();
                Console.WriteLine();
                Main();
            }
            else if (userContinue == "n")
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Sorry, I didn't get that. Lets try again");
                Main();
            }

            // The way of the note, using only one static method
            // To use, uncomment out its method which is the CHeckPalindrome() method in business logic file

            // Console.WriteLine("Palindrome Checker");
            // Console.WriteLine();
            // Console.WriteLine("Input a word to check if it is a palindrome");
            // string  word = Console.ReadLine().ToLower();
            // Console.WriteLine(PalindromeChecker.CheckPalindrome(word));

        }
    }
}