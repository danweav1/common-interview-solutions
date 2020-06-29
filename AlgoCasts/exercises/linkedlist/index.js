// --- Directions
// Implement classes Node and Linked Lists
// See 'directions' document

class Node {
  constructor(data, next = null) {
    this.data = data;
    this.next = next;
  }
}

class LinkedList {
  constructor() {
    this.head = null;
  }

  insertFirst(data) {
    this.head = new Node(data, this.head);
  }

  size() {
    let counter = 0;
    let node = this.head; // first node in linked list

    // when we first enter into it, if the linked list doesn't have a head node assigned to it, this loop
    // will fail the check.
    // If a head node does exist, we want to increment the counter, and then assign the node to the next node. It'll either be null signaling the current //// node is the end, or it'll be assigned to hte next node.
    while (node) {
      counter++;
      node = node.next;
    }

    return counter;
  }

  getFirst() {
    return this.head;
  }
}

module.exports = { Node, LinkedList };
