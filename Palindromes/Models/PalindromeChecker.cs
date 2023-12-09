using System;
using System.Collections.Generic;

namespace Palindromes.Models
{
    public class PalindromeChecker
    {
        public string PalindromeWord { get; set; }

        public PalindromeChecker(string word)
        {
            PalindromeWord = word;
        }

        // Converting the string into a string array so I can reverse it

        public string ConvertStrToCharArray()
        {
            char[] theCharArray = PalindromeWord.ToCharArray();
            // char[]  results = theCharArray.Reverse();

            Array.Reverse(theCharArray);
            string result = new string(theCharArray);

            return result;

            
        }
        
        // Writing the method without a .Reverse().... The method has no Array.Reverse() in it 
        // public static bool CheckPalindrome(string words)
        // {
        //     char[] myChar = words.ToCharArray();
        //     string reversedString = "";

        //     // A forloop
        //     for (int i = myChar.Length-1; i > -1; i--)
        //     {
        //         // first: where to start from, go to the last element... Since Length counts like: 12345 instead of counting with index 01234
        //         // Stop when i > -1
        //         // how to move: move backwards
        //         reversedString += myChar[i];

        //     }
        //     // The code below is a short way of using an if statement to determine if two values are equal....
        //     // The code below returns a boolean(true or false)
        //     return words == reversedString;
        // }

        // Determiner
        public string ResultDeterminer()
        {
            if (ConvertStrToCharArray() == PalindromeWord)
            {
                return "Your word is a palindrome";
            }
            else
            {
                return "Your word is not a Palindrome";
            }
        }   




        


        
    }
}