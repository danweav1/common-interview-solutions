using System.Collections.Generic;
using System.Linq;

namespace InterviewStuff
{
    // --- Directions
    // Given a string, return the character that is most
    // commonly used in the string.
    // --- Examples
    // maxChar("abcccccccd") === "c"
    // maxChar("apple 1231111") === "1"
    // this can be used to solve questions like "does string a have same characters as string b (is it an anagram)?" or
    // "does this string have any repeated characters in it?"
    public class MaxChar
    {
        // Solution 1 - using Linq O(n) now from micro-optimizations done
        public static char GetMaxChar1(string str)
        {
            // GroupBy takes each character in the string and puts them into groups by character, and then orders them by their count starting with the 
            // top occurance
            return str.GroupBy(c => c).OrderByDescending(c => c.Count()).First().Key;
        }

        // Solution 2 - using dictionary
        public static char GetMaxChar2(string str)
        {
            Dictionary<char, int> charMap = new Dictionary<char, int>();
            int max = 0;
            char maxChar = char.MinValue;

            foreach (char c in str)
            {
                if (charMap.ContainsKey(c))
                {
                    charMap[c]++;
                } 
                else
                {
                    charMap.Add(c, 1);
                }
            }

            foreach (KeyValuePair<char, int> kvPair in charMap)
            {
                if (kvPair.Value > max)
                {
                    max = kvPair.Value;
                    maxChar = kvPair.Key;
                }
            }

            return maxChar;
        }
    }
}
