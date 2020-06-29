// --- Directions
// Write a function that accepts a string.  The function should
// capitalize the first letter of each word in the string then
// return the capitalized string.
// --- Examples
//   capitalize('a short sentence') --> 'A Short Sentence'
//   capitalize('a lazy fox') --> 'A Lazy Fox'
//   capitalize('look, it is working!') --> 'Look, It Is Working!'

// // Solution 1
// function capitalize(str) {
//   const words = [];

//   for (let word of str.split(' ')) {
//     words.push(word[0].toUpperCase() + word.slice(1));
//   }

//   return words.join(' ');
// }

// // Solution 2 - harder to code
// function capitalize(str) {
//   let result = str[0].toUpperCase(); // always captialize the first letter in the string

//   for (let i = 1; i < str.length; i++) {
//     // look to the left of the current character.
//     if (str[i - 1] === ' ') {
//       // if it's a space, take the current character and uppercase it and add it to the result string
//       result += str[i].toUpperCase();
//     } else {
//       result += str[i];
//     }
//   }

//   return result;
// }

// Solution 3
function capitalize(str) {
  return str
    .split(' ') // split by space
    .map((word) => word[0].toUpperCase() + word.slice(1)) // turn each word into a word with the first letter uppercased
    .join(' '); // join them back into one string by spaces
}

module.exports = capitalize;
