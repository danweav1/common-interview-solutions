using System;

namespace InterviewStuff
{
    // --- Directions
    // Write a program that console logs the numbers
    // from 1 to n. But for multiples of three print
    // “fizz” instead of the number and for the multiples
    // of five print “buzz”. For numbers which are multiples
    // of both three and five print “fizzbuzz”.
    // --- Example
    //   fizzBuzz(5);
    //   1
    //   2
    //   fizz
    //   4
    //   buzz
    public class FizzBuzz
    {
        // Solution 1
        public static void DoFizzBuzz1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Solution 2
        public static void DoFizzBuzz2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string str = string.Empty;
                if (i % 3 == 0)
                {
                    str += "fizz";
                }
                if (i % 5 == 0)
                {
                    str += "buzz";
                }


                Console.WriteLine((!string.IsNullOrEmpty(str)) ? str : i.ToString()); // non-ternary way below

                //if (str != string.Empty)
                //{
                //    Console.WriteLine(str);
                //}
                //else
                //{
                //    Console.WriteLine(i);
                //}
            }
        }
    }
}
