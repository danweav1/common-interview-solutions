// --- Directions
// Write a function that accepts an integer N
// and returns a NxN spiral matrix.
// --- Examples
//   matrix(2)
//     [[1, 2],
//     [4, 3]]
//   matrix(3)
//     [[1, 2, 3],
//     [8, 9, 4],
//     [7, 6, 5]]
//  matrix(4)
//     [[1,   2,  3, 4],
//     [12, 13, 14, 5],
//     [11, 16, 15, 6],
//     [10,  9,  8, 7]]

// SOLUTION 1
function matrix(n) {
  const results = [];

  // first create the right amount of inner arrays
  for (let i = 0; i < n; i++) {
    results.push([]);
  }

  // in javascript, you can insert values to an index in an array without initializing them

  // create a counter. this will be equal to the number we are trying to enter into the array
  let counter = 1;

  // start row and column will always be index 0
  // end row and column will always be index n - 1

  let startColumn = 0;
  let endColumn = n - 1;
  let startRow = 0;
  let endRow = n - 1;

  // these are not fixed values, they will change over time to indicate which row/column we are currently working on
  while (startColumn <= endColumn && startRow <= endRow) {
    // loop from start column to end column. The first for loop will always be responsible for assembling the top row of our solution.
    for (let i = startColumn; i <= endColumn; i++) {
      results[startRow][i] = counter;
      counter++;
    }
    startRow++;

    // the next for loop will be responsible for making the right hand column starting at the next row to the last row
    for (let i = startRow; i <= endRow; i++) {
      results[i][endColumn] = counter;
      counter++;
    }

    endColumn--; // finished with the last column, so decrement it

    // for the bottom row values.
    for (let i = endColumn; i >= startColumn; i--) {
      results[endRow][i] = counter;
      counter++;
    }

    endRow--; // we're finished with end row, so decrement it

    // for the starting column remaining values
    for (let i = endRow; i >= startRow; i--) {
      results[i][startColumn] = counter;
      counter++;
    }

    startColumn++; // done with start column, so move to the right
  }

  return results;
}

module.exports = matrix;
