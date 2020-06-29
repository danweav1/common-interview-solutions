using System;
using System.Text;

namespace InterviewStuff
{
    // --- Directions
    // Given a string, return a new string with the reversed
    // order of characters
    // --- Examples
    //   reverse('apple') === 'leppa'
    //   reverse('hello') === 'olleh'
    //   reverse('Greetings!') === '!sgniteerG'
    public class Reversestring
    {
        // Solution 1 - fastest
        public static string Reverse1(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        // Solution 2
        public static string Reverse2(string str)
        {
            string reversed = "";

            foreach (char c in str)
            {
                reversed = c + reversed;
            }

            return reversed;
        }

        // Solution 3
        public static string Reverse3(string str)
        {
            StringBuilder builder = new StringBuilder(str.Length);
            for (int i = str.Length - 1; i >= 0; i--)
            {
                builder.Append(str[i]);
            }

            return builder.ToString();
        }
    }
}
