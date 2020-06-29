// --- Directions
// Write a function that returns the number of vowels
// used in a string.  Vowels are the characters 'a', 'e'
// 'i', 'o', and 'u'.
// --- Examples
//   vowels('Hi There!') --> 3
//   vowels('Why do you ask?') --> 4
//   vowels('Why?') --> 0

// // SOLUTION 1 - iterative solution
// function vowels(str) {
//   // iterate through all characters in string, and if character is a vowel, increase the counter
//   let count = 0;
//   const allVowels = ['a', 'e', 'i', 'o', 'u']; // can also use a string instead like in comment below. string and arrays both contain the .includes function
//   // const allVowels = 'aeiou';

//   for (let char of str.toLowerCase()) {
//     // if the character we are looking at is included in the 'allVowels' string, increase the counter
//     if (allVowels.includes(char)) {
//       count++;
//     }
//   }

//   return count;
// }

// // SOLUTION 2 - using regex expression
// function vowels(str) {
//   //[] means if this string contains any character inside the square brackets then let us know
//   // the 'g' option makes sure we don't stop at first match we find inside our string
//   // the 'i' means case insensitive
//   const matches = str.match(/[aeiou]/gi); // .match returns an array of all the matches that were found. if no matches were found, it'll return null

//   return matches ? matches.length : 0; // if matches is null, return 0, otherwise return the length
// }

// SOLUTION 3 - shorter regex expression
function vowels(str) {
  return str.replace(/[^euioa]/gi, '').length; // The ^ gets all the characters that are NOT euioa. The .replace turns all of those into empty strings, so all's that is left are vowels.
}

module.exports = vowels;
