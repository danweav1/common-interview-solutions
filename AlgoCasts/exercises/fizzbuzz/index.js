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

// // Solution 1
// function fizzBuzz(n) {
//   for (let i = 1; i <= n; i++) {
//     // check if n is a multiple of 3 and 5
//     // instead of if (i % 3 === 0 && i % 5 === 0), you can do below becaues anything a multiple of 3 and 5 will be a multiple of 15
//     if (i % 15 === 0) {
//       console.log('fizzbuzz');
//     } else if (i % 3 === 0) {
//       console.log('fizz');
//     } else if (i % 5 === 0) {
//       console.log('buzz');
//     } else {
//       console.log(i);
//     }
//   }
// }

// Solution 2 - slightly fancier way
function fizzBuzz(n) {
  for (let i = 1; i <= n; i++) {
    let str = '';
    if (i % 3 === 0) str += 'fizz';
    if (i % 5 === 0) str += 'buzz';
    console.log(str || i); // empty string is falsey, so if the string is still '', then i will print instead.
  }
}

module.exports = fizzBuzz;
