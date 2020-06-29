// --- Directions
// Write a function that accepts a positive number N.
// The function should console log a step shape
// with N levels using the # character.  Make sure the
// step has spaces on the right hand side!
// --- Examples
//   steps(2)
//       '# '
//       '##'
//   steps(3)
//       '#  '
//       '## '
//       '###'
//   steps(4)
//       '#   '
//       '##  '
//       '### '
//       '####'

// // Solution 1 - based on n, we had two for loops, one nested in the other. So each time the input 'n' was increased, we had to do way more things
// // It is NOT a one to one relationship. It was n^2 (quadratic runtime)
// function steps(n) {
//   for (let row = 0; row < n; row++) {
//     // first iterate through the rows
//     let stair = '';

//     for (let column = 0; column < n; column++) {
//       // then iterate through the columns
//       if (column <= row) {
//         // if the column is less than the row
//         stair += '#'; // add a #
//       } else {
//         stair += ' '; // otherwise add a space
//       }
//     }

//     console.log(stair);
//   }
// }

// // Solution 2 - using recursion
// // set default value row to 0 so we always start on the first row
// // set stair to an empty string intially
// function steps(n, row = 0, stair = '') {
//   if (n === row) {
//     return;
//   }

//   if (n === stair.length) {
//     console.log(stair);
//     return steps(n, row + 1); // when we move onto the next row, we want to use an empty stair again, so don't pass it here and just use the initial value
//   }

//   // if (stair.length <= row) {
//   //   stair += '#';
//   // } else {
//   //   stair += ' ';
//   // }
//   // steps(n, row, stair);

//   // same as above
//   const add = stair.length <= row ? '#' : ' ';
//   steps(n, row, stair + add);
// }

// Solution 3 - easiest solution
function steps(n) {
  for (let i = 1; i <= n; i++) {
    console.log('#'.repeat(i) + ' '.repeat(n - i));
  }
}

module.exports = steps;
