// --- Directions
// Given a string, return the character that is most
// commonly used in the string.
// --- Examples
// maxChar("abcccccccd") === "c"
// maxChar("apple 1231111") === "1"
// this can be used to solve questions like "does string a have same characters as string b (is it an anagram)?" or
// "does this string have any repeated characters in it?"

// Solution 1 - build a map of characters
function maxChar(str) {
  const charMap = {};
  let max = 0;
  let maxChar = '';

  for (let char of str) {
    // loop through each characterin the string
    if (charMap[char]) {
      // if our charMap object already contains an entry for the current char
      charMap[char]++; // then increment it by 1
    } else {
      charMap[char] = 1; // otherwise set it's value to 1
    }
  }

  for (let char in charMap) {
    // loop through each entry in our charMap object
    if (charMap[char] > max) {
      // if the value for the current entry is greater than our max variable
      max = charMap[char]; // set max equal to the current value
      maxChar = char; // and set the maxChar variable to the current char entry
    }
  }

  return maxChar;
}

module.exports = maxChar;
