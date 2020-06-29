// --- Directions
// Given an array and chunk size, divide the array into many subarrays
// where each subarray is of length size. Any extra numbers are put into their own array.
// --- Examples
// chunk([1, 2, 3, 4], 2) --> [[ 1, 2], [3, 4]]
// chunk([1, 2, 3, 4, 5], 2) --> [[ 1, 2], [3, 4], [5]]
// chunk([1, 2, 3, 4, 5, 6, 7, 8], 3) --> [[ 1, 2, 3], [4, 5, 6], [7, 8]]
// chunk([1, 2, 3, 4, 5], 4) --> [[ 1, 2, 3, 4], [5]]
// chunk([1, 2, 3, 4, 5], 10) --> [[ 1, 2, 3, 4, 5]]

// Solution 1
function chunk(array, size) {
  // Create empty array to hold chunks called 'chunked'
  const chunked = [];

  // For each element in the 'unchunked' array
  for (let element of array) {
    const last = chunked[chunked.length - 1]; // Retrieve the last element in 'chunked'

    // If the last element does not exist, or if its length is equal to chunk size
    if (!last || last.length === size) {
      chunked.push([element]); // Push a new chunk into 'chunked' with the current element
    } else {
      last.push(element); // Else add the current element into the chunk
    }
  }

  return chunked;
}

// Solution 2
function chunk(array, size) {
  const chunked = []; // Create empty 'chunked' array
  let index = 0; // Create 'index' start at 0

  // While index is less than array.length
  while (index < array.length) {
    chunked.push(array.slice(index, index + size)); // Push a slice of length 'size' from 'array' into 'chunked'
    index += size; // Add 'size' to index
  }

  return chunked;
}

module.exports = chunk;
