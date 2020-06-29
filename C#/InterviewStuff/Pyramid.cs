using System;
using System.Linq;

namespace InterviewStuff
{
    // --- Directions
    // Write a function that accepts a positive number N.
    // The function should console log a pyramid shape
    // with N levels using the # character.  Make sure the
    // pyramid has spaces on both the left *and* right hand sides
    // --- Examples
    //   pyramid(1)
    //       '#'
    //   pyramid(2)
    //       ' # '
    //       '###'
    //   pyramid(3)
    //       '  #  '
    //       ' ### '
    //       '#####'
    public class Pyramid
    {
        // SOLUTION 1
        public static void DoPyramid1(int n)
        {
            double midpoint = Math.Floor(((2 * n) - 1) / 2.0);

            for (int row = 0; row < n; row++)
            {
                string level = "";

                for (int column = 0; column < (2 * n) - 1; column++)
                {
                    if (midpoint - row <= column && midpoint + row >= column)
                    {
                        level += "#";
                    }
                    else
                    {
                        level += " ";
                    }
                }
                Console.WriteLine(level);
            }
        }

        // SOLUTION 2 - using recursion
        public static void DoPyramid2(int n, int row = 0, string level = "")
        {
            if (row == n)
            {
                return;
            }

            if (level.Length == (2 * n) - 1)
            {
                Console.WriteLine(level);
                DoPyramid2(n, row + 1);
                return;
            }

            double midpoint = Math.Floor(((2 * n) - 1) / 2.0);
            string add = midpoint - row <= level.Length && midpoint + row >= level.Length ? "#" : " ";
            DoPyramid2(n, row, level + add);
        }

        // SOLUTION 3 - using recursion but shorter
        public static void DoPyramid3(int n, int poundCount = 1)
        {
            if (n <= 0)
            {
                return;
            }

            Console.WriteLine(new string(' ', n - 1) +  new string('#', poundCount) + new string(' ', n - 1));
            DoPyramid3(n - 1, poundCount + 2);
        }

        // SOLUTION 4 - very similar to above but slightly easier to understand/read
        public static void DoPyramid4(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string emptyStr = " ";
                emptyStr = string.Concat(Enumerable.Repeat(emptyStr, n - i - 1));

                string hash = "#";
                hash = string.Concat(Enumerable.Repeat(hash, (i * 2) + 1));
                Console.WriteLine(emptyStr + hash + emptyStr);
            }
        }
    }
}
