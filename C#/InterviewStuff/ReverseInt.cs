using System;
using System.Linq;

namespace InterviewStuff
{
    // --- Directions
    // Given an integer, return an integer that is the reverse
    // ordering of numbers.
    // --- Examples
    //   reverseInt(15) === 51
    //   reverseInt(981) === 189
    //   reverseInt(500) === 5
    //   reverseInt(-15) === -51
    //   reverseInt(-90) === -9
    public class ReverseInt
    {
        // Solution 1
        public static int ReverseInteger1(int n)
        {
            // Start a counter that is incrementing to your reversed number.
            int reverse = 0;

            // Because of integer decimal truncation, eventually dividing an integer by 
            // 10 every step will result in 0!
            while (n != 0)
            {
                // The remainder of any integer divided by 10 will always be the last 
                // number.
                // I.E. 11234 / 10 = 1123 - Remainder 4
                int remainder = n % 10;

                // Multiply that last reversed number you had cached by 10 and add the 
                // remainder from above.
                // I.E. On the first step - 0 * 10 + 4 = 4
                // Reverse is now 4.
                reverse = reverse * 10 + remainder;

                // Finally, actually divide your given number by 10 so on the next 
                // iteration your remainder will calculate based on the new number.
                // Note that because is an INTEGER the decimal is truncated leaving 
                // you with a whole number.
                n /= 10;
            }

            // The final number post loop will be your number reversed. 
            // Note that this truncates numbers such as 100 to 1 instead of 001. 
            // This also preserves the negative sign.
            return reverse;
        }

        // Solution 2 - using Math.Sign
        public static int ReverseInteger2(int n)
        {
            char[] charArray = n.ToString().ToCharArray(); //first convert the number into a string and then char array
            Array.Reverse(charArray); // reverse the char array
            // use Linq's TakeWhile to only take characters that are digits, thus removing any minus signs, and then parse it into an int.
            // Then multiply it by Math.Sign of the original number to keep the sign of the original number
            return int.Parse(charArray.TakeWhile(c => char.IsDigit(c)).ToArray()) * Math.Sign(n);
        }
    }
}
