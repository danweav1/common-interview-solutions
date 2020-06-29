using System;
using System.Linq;

namespace InterviewStuff
{
    // --- Directions
    // Given a string, return true if the string is a palindrome
    // or false if it is not.  Palindromes are strings that
    // form the same word if it is reversed. *Do* include spaces
    // and punctuation in determining if the string is a palindrome.
    // --- Examples:
    //   palindrome("abba") === true
    //   palindrome("abcdefg") === false
    public class Palindrome
    {
        // SOLUTION 1 - fastest
        public static bool IsPalindrome1(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);
            return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
        }

        // SOLUTION 2 
        public static bool IsPalindrome2(string str)
        {
            return str.ToCharArray().All((c) =>
                string.Equals(c, str[str.Length - str.IndexOf(c) - 1])
            );
        }
    }
}
