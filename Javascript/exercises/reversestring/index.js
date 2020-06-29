// --- Directions
// Given a string, return a new string with the reversed
// order of characters
// --- Examples
//   reverse('apple') === 'leppa'
//   reverse('hello') === 'olleh'
//   reverse('Greetings!') === '!sgniteerG'

// SOLUTION 3 most advanced
function reverse(str) {
  return str.split('').reduce((rev, char) => char + rev, ''); // first turn into an array, and use reduce take all the values of an array and condense them to one single value
}

module.exports = reverse;

// // SOLUTION 2 - o(n) - linear runtime because each additional character is 1 step
// function reverse(str) {
//   let reversed = '';

//   // whenever possible, avoid writing forloops in classic syntax
//   // use the for of syntax, ONLY when you need to iterate through every object.
//   for (let character of str) {
//     reversed = character + reversed;
//   }

//   return reversed;
// }

// SOLUTION 1
// function reverse(str) {
//   // const arr = str.split(''); // first turn the string into an array of characters
//   // arr.reverse(); // reverses all the elements
//   // return arr.join(''); // joins all the elements back into a string

//   // can condense it like so:
//   return str.split('').reverse().join('');
// }
