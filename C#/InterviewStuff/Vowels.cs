using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace InterviewStuff
{
    // --- Directions
    // Write a function that returns the number of vowels
    // used in a string.  Vowels are the characters 'a', 'e'
    // 'i', 'o', and 'u'.
    // --- Examples
    //   vowels('Hi There!') --> 3
    //   vowels('Why do you ask?') --> 4
    //   vowels('Why?') --> 0
    public class Vowels
    {
        // SOLUTION 1 - iterative solution
        public static int GetNumVowels1(string str)
        {
            int count = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' }; // could make this a string too like "aeiou". String also has the .Contains function

            foreach (char c in str.ToLower())
            {
                if (vowels.Contains(c)) // could also use Array.IndexOf(vowels, c) which would return -1 if not found instead of true/false
                {
                    count++;
                }
            }

            return count;
        }

        // SOLUTION 2 - using regex expression
        public static int GetNumVowels2(string str)
        {
            return Regex.Matches(str, @"[aeiou]", RegexOptions.IgnoreCase).Count;
        }

        // SOLUTION 3 - using regex with .Replace instead
        public static int GetNumVowels3(string str)
        {
            return Regex.Replace(str, @"[^aeiou]", "", RegexOptions.IgnoreCase).Length;
        }
    }
}
