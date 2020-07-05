// --- Directions
// 1) Create a node class.  The constructor
// should accept an argument that gets assigned
// to the data property and initialize an
// empty array for storing children. The node
// class should have methods 'add' and 'remove'.
// 2) Create a tree class. The tree constructor
// should initialize a 'root' property to null.
// 3) Implement 'traverseBF' and 'traverseDF'
// on the tree class.  Each method should accept a
// function that gets called with each element in the tree

class Node {
  constructor(data) {
    this.data = data;
    this.children = [];
  }

  add(data) {
    this.children.push(new Node(data));
  }

  remove(data) {
    this.children = this.children.filter((node) => {
      return node.data !== data;
    });
  }
}

class Tree {
  constructor() {
    this.root = null;
  }

  traverseBF(fn) {
    const arr = [this.root];

    // while the array has something in it still
    while (arr.length) {
      const node = arr.shift(); // taking first element out of the array

      arr.push(...node.children); // ...takes each element in node.children and is pushed into arr one by one

      // // alternative solution instead of spread operator above
      // for (let child of node.children) {
      //   arr.push(child);
      // }

      fn(node);
    }
  }

  // // Alternative
  // traverseBF(fn) {
  //   if (!this.root) return
  //   let q = []
  //   q.unshift(this.root)
  //   while (q.length !== 0) {
  //     let curr = q.pop()
  //     fn(curr)
  //     for (let node of curr.children) {
  //       q.unshift(node)
  //     }
  //   }
  // }

  traverseDF(fn) {
    const arr = [this.root];

    // while the array still has something in it
    while (arr.length) {
      const node = arr.shift(); // take first element out of array

      arr.unshift(...node.children); // add each child element to the front of array
      fn(node);
    }
  }

  // // Alternative
  // traverseDF(fn, node = this.root) {
  //   fn(node);
  //   if (node) node.children.forEach((node) => this.traverseDF(fn, node));
  // }
}

module.exports = { Tree, Node };
