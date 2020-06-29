// --- Directions
// Given a string, return true if the string is a palindrome
// or false if it is not.  Palindromes are strings that
// form the same word if it is reversed. *Do* include spaces
// and punctuation in determining if the string is a palindrome.
// --- Examples:
//   palindrome("abba") === true
//   palindrome("abcdefg") === false

// SOLUTION 1 - fastest
function palindrome(str) {
  let reversed = str.split('').reverse().join('');
  return str === reversed;
}

// // SOLUTION 2
// function palindrome(str) {
//   return str.split('').every((char, i) => {
//     // split the string into a char array, and using 'every', you get each char and it's index.
//     return char === str[str.length - i - 1]; // compare the char to the opposite end char
//   });
// }

module.exports = palindrome;
