// --- Directions
// 1) Implement the Node class to create
// a binary search tree.  The constructor
// should initialize values 'data', 'left',
// and 'right'.
// 2) Implement the 'insert' method for the
// Node class.  Insert should accept an argument
// 'data', then create an insert a new node
// at the appropriate location in the tree.
// 3) Implement the 'contains' method for the Node
// class.  Contains should accept a 'data' argument
// and return the Node in the tree with the same value.

class Node {
  constructor(data) {
    this.data = data;
    this.left = null;
    this.right = null;
  }

  insert(data) {
    // the data should go where there is already a node, delegate it the insertion to the existing node
    if (data < this.data && this.left) {
      this.left.insert(data); // node already exists at left, so it should handle the insertion
    } else if (data < this.data) {
      this.left = new Node(data);
    } else if (data > this.data && this.right) {
      this.right.insert(data); // node already exists at right, so it should handle the insertion
    } else if (data > this.data) {
      this.right = new Node(data);
    }
  }

  // // alternative using ternary opertaions
  // insert(data) {
  //   const node = new Node(data);

  //   if (data < this.data) {
  //     this.left ? this.left.insert(data) : (this.left = node);
  //   } else {
  //     this.right ? this.right.insert(data) : (this.right = node);
  //   }
  // }

  // remember, if the node you are looking for is less than the root node, you DON'T have to traverse the right side. vice versa for a node greater than
  // the root node
  contains(data) {
    if (data === this.data) {
      return this; // current node is equal to the value we're looking for
    }

    // if the data we're looking for is greater than the current node's data, check the right hand side and make sure there IS a node on the right
    if (data > this.data && this.right) {
      return this.right.contains(data);
    } else if (data < this.data && this.left) {
      // data we are looking for is on left hand side
      return this.left.contains(data);
    }

    return null; // if we don't find the node we're looking for
  }
}

module.exports = Node;
