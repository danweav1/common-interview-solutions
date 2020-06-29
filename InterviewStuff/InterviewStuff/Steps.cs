using System;

namespace InterviewStuff
{
    // --- Directions
    // Write a function that accepts a positive number N.
    // The function should console log a step shape
    // with N levels using the # character.  Make sure the
    // step has spaces on the right hand side!
    // --- Examples
    //   steps(2)
    //       '# '
    //       '##'
    //   steps(3)
    //       '#  '
    //       '## '
    //       '###'
    //   steps(4)
    //       '#   '
    //       '##  '
    //       '### '
    //       '####'
    public class Steps
    {
        // Solution 1
        public static void DoSteps1(int n)
        {
            int row;
            int column;

            for (row = 0; row < n; row++)
            {
                string stair = "";

                for (column = 0; column < n; column++)
                {
                    if (column <= row)
                    {
                        stair += '#';
                    }
                    else
                    {
                        stair += ' ';
                    }
                }
                Console.WriteLine(stair);
            }
        }

        // Solution 2 - using recursion
        public static void DoSteps2(int n, int row = 0, string stair = "")
        {
            if (n == row)
            {
                return;
            }

            if (n == stair.Length)
            {
                Console.WriteLine(stair);
                DoSteps2(n, row + 1);
                return;
            }

            if (stair.Length <= row)
            {
                stair += "#";
            }
            else
            {
                stair += " ";
            }

            DoSteps2(n, row, stair);
        }

        // Solution 3 - easiest solution
        public static void DoSteps3(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('#', i) + new string(' ', n - 1));
            }
        }
    }
}
