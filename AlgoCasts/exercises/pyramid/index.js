// --- Directions
// Write a function that accepts a positive number N.
// The function should console log a pyramid shape
// with N levels using the # character.  Make sure the
// pyramid has spaces on both the left *and* right hand sides
// --- Examples
//   pyramid(1)
//       '#'
//   pyramid(2)
//       ' # '
//       '###'
//   pyramid(3)
//       '  #  '
//       ' ### '
//       '#####'

// // SOLUTION 1
// // We take n and double it, then subtract 1 to give us the total number of columns
// function pyramid(n) {
//   // calculate the mid point of row
//   const midpoint = Math.floor((2 * n - 1) / 2);

//   for (let row = 0; row < n; row++) {
//     let level = '';

//     // calculate the mid point (center index) of the columns. Take 'row' number of elements on both sides of the center and make it a '#'
//     for (let column = 0; column < 2 * n - 1; column++) {
//       // Makes sure the current column we are looking at is within the bounds of midpoint - row and midpoint + row
//       if (midpoint - row <= column && midpoint + row >= column) {
//         level += '#';
//       } else {
//         level += ' ';
//       }
//     }
//     console.log(level);
//   }
// }

// // SOLUTION 2 - using recursion
// function pyramid(n, row = 0, level = '') {
//   if (row === n) {
//     return;
//   }

//   // detect when we're at the end of a level (very right hand side).
//   if (level.length === 2 * n - 1) {
//     console.log(level); // log current level
//     return pyramid(n, row + 1); // move on to next row
//   }

//   // calculate the mid point
//   const midpoint = Math.floor((2 * n - 1) / 2);
//   let add; // contain character we're supposed to add to our string
//   if (midpoint - row <= level.length && midpoint + row >= level.length) {
//     add = '#';
//   } else {
//     add = ' ';
//   }
//   pyramid(n, row, level + add);
// }

// // SOLUTION 3 - also using recursion but shorter
// function pyramid(n, poundCount = 1) {
//   if (n <= 0) return;

//   console.log(' '.repeat(n - 1) + '#'.repeat(poundCount) + ' '.repeat(n - 1));
//   pyramid(n - 1, poundCount + 2);
// }

// SOLUTION 4 - very similar to above but slightly easier to understand/read
function pyramid(n) {
  for (let i = 0; i < n; i++) {
    let emptyStr = ' ';
    emptyStr = emptyStr.repeat(n - i - 1);

    let hash = '#';
    hash = hash.repeat(i * 2 + 1);
    console.log(emptyStr + hash + emptyStr);
  }
}

module.exports = pyramid;
