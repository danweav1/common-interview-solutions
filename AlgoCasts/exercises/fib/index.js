// --- Directions
// Print out the n-th entry in the fibonacci series.
// The fibonacci series is an ordering of numbers where
// each number is the sum of the preceeding two.
// For example, the sequence
//  [0, 1, 1, 2, 3, 5, 8, 13, 21, 34]
// forms the first ten entries of the fibonacci series.
// Example:
//   fib(4) === 3

// // SOLUTION 1 - Iterative Solution - for every increase in n, we have to calculate one additional number. As n increased by 1, we do one more calculation
// // and that will never change, so it's linear run time. Also, it's a single for loop always incrementing by 1, so O(n).
// function fib(n) {
//   // the trick is to recongize the first two numbers can't be generated by a for loop. We always know it's going to be 0 and 1.
//   // so best way is to manually insert them into the results set.
//   const result = [0, 1];

//   // we start looping at the third element
//   for (let i = 2; i <= n; i++) {
//     const a = result[i - 1]; // can also do result[result.length - 1] to get previous record
//     const b = result[i - 2];

//     result.push(a + b);
//   }

//   return result[n]; // return the last entry. could also do result[result.length - 1]
// }

// // SOLUTION 2 - Recursive Solution - basically a bunch of 1's and 0's will be returned and added up to give the number we need
// // For example, if n = 6, 1 will be returned 8 times. The 6th element of the fib sequence is 8.
// // This is exponential time: 2^n. For each additional element, we are experience a dramatic increase in number of function calls required.
// // This is a no no. Other solution is better.

// // If you look at the function calls, many are being repeated. For instance when n =  6, fib(3) is being called 3 times.
// // If interview asks you if there's someway to improve it, the answer is yes: memoization (solution further down)
// function fib(n) {
//   if (n < 2) {
//     return n;
//   }

//   return fib(n - 1) + fib(n - 2);
// }

// // SOLUTION 3 - no array used, no recursion
// function fib(n) {
//   let current = 1;
//   let oneBack = 0;

//   for (let i = 1; i < n; i++) {
//     current += oneBack;
//     oneBack = current - oneBack;
//   }

//   return current;
// }

// SOLUTION 4 - another type of recursion solution
function fib(n, init = 0, last = 1, count = 1) {
  if (n === count) {
    return last;
  } else {
    count++;
    return fib(n, last, init + last, count);
  }
}

// // SOLUTION 5 - using memoization. This uses caching arguments we've already passed.
// function memoize(fn) {
//   const cache = {};
//   // below will be the faster version
//   // ... means don't know how many arguments will be sent, so just take them all as an array of arguments
//   return function (...args) {
//     // have we called this function with this set of arguments before?
//     if (cache[args]) {
//       return cache[args]; // if we have, just return the original value
//     }

//     const result = fn.apply(this, args);
//     cache[args] = result;

//     return result;
//   };
// }

// // The slow function.
// // Before we call this, create a cache object. The keys are the arguments we were trying to call slowFib with (some number).
// function fib(n) {
//   if (n < 2) {
//     return n;
//   }

//   return fib(n - 1) + fib(n - 2);
// }

// fib = memoize(fib);

module.exports = fib;
