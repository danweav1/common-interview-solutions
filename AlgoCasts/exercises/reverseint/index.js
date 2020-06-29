// --- Directions
// Given an integer, return an integer that is the reverse
// ordering of numbers.
// --- Examples
//   reverseInt(15) === 51
//   reverseInt(981) === 189
//   reverseInt(500) === 5
//   reverseInt(-15) === -51
//   reverseInt(-90) === -9

// Solution 1
function reverseInt(n) {
  const reversed = n.toString().split('').reverse().join(''); // convert number to a string, then split it into char array, reverse it, and join it back to a string
  //parseInt sees a number in a string and removes the other characters
  return parseInt(reversed) * Math.sign(n); // math.sign returns 1 for positive number, -1 for negative, and 0 for zero
}

// // Solution 2 using integer decimal truncation
// function reverseInt(n) {
//   // Start a counter that is incrementing to your reversed number.
//   let reverse = 0;

//   // Because of integer decimal truncation, eventually dividing an integer by
//   // 10 every step will result in 0!
//   while (n !== 0) {
//     // The remainder of any integer divided by 10 will always be the last
//     // number.
//     // I.E. 11234 / 10 = 1123 - Remainder 4
//     const remainder = n % 10;

//     // Multiply that last reversed number you had cached by 10 and add the
//     // remainder from above.
//     // I.E. On the first step - 0 * 10 + 4 = 4
//     // Reverse is now 4.
//     reverse = reverse * 10 + remainder;

//     // Finally, actually divide your given number by 10 so on the next
//     // iteration your remainder will calculate based on the new number.
//     // Note that because is an INTEGER the decimal is truncated (using Math.trunc) leaving
//     // you with a whole number.
//     pNum = Math.trunc(n / 10);
//   }

//   // The final number post loop will be your number reversed.
//   // Note that this truncates numbers such as 100 to 1 instead of 001.
//   // This also preserves the negative sign.
//   return reverse;
// }

module.exports = reverseInt;
