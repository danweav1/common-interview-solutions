using System.Collections.Generic;
using System.Globalization;

namespace InterviewStuff
{
    // --- Directions
    // Write a function that accepts a string.  The function should
    // capitalize the first letter of each word in the string then
    // return the capitalized string.
    // --- Examples
    //   capitalize('a short sentence') --> 'A Short Sentence'
    //   capitalize('a lazy fox') --> 'A Lazy Fox'
    //   capitalize('look, it is working!') --> 'Look, It Is Working!'
    public class SentenceCapitalization
    {
        // Solution 1
        public static string Capitalize1(string str)
        {
            List<string> words = new List<string>();
            foreach (string word in str.Split(' '))
            {
                words.Add(word[0].ToString().ToUpper() + word.Substring(1));
            }

            return string.Join(' ', words);
        }

        // Solution 2 - Using built in .NET method
        public static string Capitalize2(string str)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(str);
        }

        // Solution 3 - harder to code
        public static string Capitalize3(string str)
        {
            string result = str[0].ToString().ToUpper(); // always capitalize the first letterin the string

            // Start with second character because we already dealt with the first in the previous line
            for (int i = 1; i < str.Length; i++)
            {
                // look to the left of the current character
                if (str[i - 1] == ' ')
                {
                    // if it's a space, take the current character and uppercase it and add it to the result string
                    result += str[i].ToString().ToUpper();
                }
                else
                {
                    result += str[i];
                }
            }

            return result;
        }
    }
}
