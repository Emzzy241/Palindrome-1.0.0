using System;

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

        public string ConvertStrToCharArray(string theWord)
        {
            char[] theCharArray = theWord.ToCharArray();
            // char[]  results = theCharArray.Reverse();

            Array.Reverse(theCharArray);
            string result = new string(theCharArray);

            return result;

            
        }

        // Determiner
        public string ResultDeterminer()
        {
        if (ConvertStrToCharArray() == word)
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