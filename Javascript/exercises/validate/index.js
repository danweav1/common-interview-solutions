// --- Directions
// Given a node, validate the binary search tree,
// ensuring that every node's left hand child is
// less than the parent node's value, and that
// every node's right hand child is greater than
// the parent

function validate(node, min = null, max = null) {
  // haven't yet set a max bound AND we have a max value but the current node is out of bounds of that value, then something is wrong
  if (max !== null && node.data > max) {
    return false;
  }

  // same as above but for min
  if (min !== null && node.data < min) {
    return false;
  }

  // if there is a node on the left, and calling validate on that node returns false, then something went wrong
  if (node.left && !validate(node.left, min, node.data)) {
    return false;
  }

  // same as above but for right side
  if (node.right && !validate(node.right, node.data, max)) {
    return false;
  }

  return true;
}

// // Alternative solution infinity instead of null
// function validate(node, min = -Infinity, max = Infinity) {
//   if (node.data <= min || node.data >= max) return false;
//   if (node.left) return validate(node.left, min, node.data);
//   if (node.right) return validate(node.right, node.data, max);
//   return true;
// }

module.exports = validate;
