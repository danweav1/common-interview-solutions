using System;
using System.Linq;

namespace InterviewStuff
{
    // --- Directions
    // Check to see if two provided strings are anagrams of eachother.
    // One string is an anagram of another if it uses the same characters
    // in the same quantity.
    // --- Examples
    //   anagrams('rail safety', 'fairy tales') --> True
    //   anagrams('RAIL! SAFETY!', 'fairy tales') --> True
    //   anagrams('Hi there', 'Bye there') --> False
    public class Anagrams
    {
        // Solution 1 - fast way
        public static bool IsAnagram1(string stringA, string stringB)
        {
            stringA = stringA.ToLower();
            stringB = stringB.ToLower();

            if (string.IsNullOrEmpty(stringA) || string.IsNullOrEmpty(stringB)) // make sure the strings aren't empty
                return false;
            if (stringA.Length != stringB.Length) // if the strings aren't equal in length, then they aren't an anagram
                return false;

            foreach (char c in stringB) // loop through each characterin stringB
            {
                int ix = stringA.IndexOf(c); // get the index of the same character in stringA
                if (ix >= 0) // if the character doesn't exist in stringA, it'll be -1, otherwise it'll be greater than or equal to 0
                    stringA = stringA.Remove(ix, 1); // remove the current char from stringA
                else
                    return false;
            }

            return string.IsNullOrEmpty(stringA);
        }

        // Solution 2 - simple way using linq
        public static bool IsAnagram2(string stringA, string stringB)
        {
            return stringA.OrderBy(c => c).SequenceEqual(stringB.OrderBy(c => c));
        }
    }
}
