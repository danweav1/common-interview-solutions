// --- Directions
// Implement bubbleSort, selectionSort, and mergeSort
// assuming arr is array of numbers

// worst case is n^2
function bubbleSort(arr) {
  // Implement bubblesort
  for (let i = 0; i < arr.length; i++) {
    for (let j = 0; j < arr.length - i - 1; j++) {
      if (arr[j] > arr[j + 1]) {
        const lesser = arr[j + 1];
        arr[j + 1] = arr[j];
        arr[j] = lesser;
      }
    }
  }

  // return the sorted array
  return arr;
}

// worst case is n^2
function selectionSort(arr) {
  for (let i = 0; i < arr.length; i++) {
    let indexOfMin = i;
    for (let j = i + 1; j < arr.length; j++) {
      if (arr[j] < arr[indexOfMin]) {
        indexOfMin = j;
      }
    }

    if (indexOfMin !== i) {
      let lesser = arr[indexOfMin];
      arr[indexOfMin] = arr[i];
      arr[i] = lesser;
    }
  }

  return arr;
}

// worst case is n*log(n)
function mergeSort(arr) {
  // first check if the array only has one element
  if (arr.length === 1) {
    return arr;
  }

  // divide the array into two equal halfs
  // find the center of the array
  const center = Math.floor(arr.length / 2); // i.e. a length of four will give us the center at index 2; a b c d, c would be the center
  const left = arr.slice(0, center); // take everything from index 0 up to but not including the center value;
  const right = arr.slice(center); // take everything from the center index to the end of the array

  // recursively call the mergeSort algorithm on both halves
  return merge(mergeSort(left), mergeSort(right));
}

function merge(left, right) {
  const results = [];

  // while there are still elements in both arrays
  while (left.length && right.length) {
    if (left[0] < right[0]) {
      results.push(left.shift()); // remove first element in left and add it to results
    } else {
      results.push(right.shift());
    }
  }

  return [...results, ...left, ...right]; // creates new empty array, takes all elements in results and adds them, left, and then right. same as concat
}

module.exports = { bubbleSort, selectionSort, mergeSort, merge };
