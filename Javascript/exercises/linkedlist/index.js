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

  // size() alternative solution
  // size() {
  //   if (!this.head) return 0
  //   let node = this.head
  //   for (let i = 1; node !== null; i++) {
  //     node = node['next']
  //     if (node == null) return i;
  //   }
  // }

  getFirst() {
    return this.head;
  }

  getLast() {
    // check if there are any nodes first
    if (!this.head) {
      return null;
    }

    // need to iterate through list and get to last node
    let node = this.head;
    while (node) {
      // if node.next is null, that means we're at the last node
      if (!node.next) {
        return node;
      }
      node = node.next;
    }

    return node;
  }

  // getLast() shorter alternative
  // getLast() {
  //   let node = this.head;
  //   while (node.next) {
  //     node = node.next;
  //   }
  //   return node;
  // }

  clear() {
    this.head = null;
  }

  removeFirst() {
    // check if there is a head node first
    if (!this.head) {
      return;
    }

    this.head = this.head.next;
  }

  removeLast() {
    // check if there is a node
    if (!this.head) {
      return;
    }

    // check if there is only one node
    if (!this.head.next) {
      this.head = null;
      return;
    }

    let previous = this.head;
    let node = this.head.next;

    // while there is a next node
    while (node.next) {
      previous = node;
      node = node.next;
    }
    previous.next = null;
  }

  // removeLast() alternative
  // removeLast() {
  //   if (this.size() === 0 || this.size() === 1) {
  //     this.head = null;
  //     return;
  //   }

  //   let node = this.head;
  //   while (node) {
  //     if (!node.next.next) {
  //       node.next = null;
  //       return;
  //     }
  //     node = node.next;
  //   }
  // }

  insertLast(data) {
    const last = this.getLast();

    if (last) {
      // There are some existing nodes in our chain
      last.next = new Node(data);
    } else {
      // The chain is empty!
      this.head = new Node(data);
    }
  }

  getAt(index) {
    let counter = 0;
    let node = this.head;

    // while we have another node
    while (node) {
      if (counter === index) {
        return node;
      }

      counter++;
      node = node.next;
    }
    return null;
  }

  removeAt(index) {
    if (!this.head) {
      return;
    }

    // if it's the first node
    if (index === 0) {
      this.head = this.head.next;
    }

    const previous = this.getAt(index - 1);
    if (!previous || !previous.next) {
      return;
    }
    previous.next = previous.next.next; // getting rid of the middle node which is previous.next
  }

  // // alternative for removeAt()
  // removeAt(index) {
  //   if (index === 0) {
  //     this.head = this.head ? this.head.next : null;
  //     return;
  //   }
  //   const previous = this.getAt(index - 1);
  //   if (previous) {
  //     previous.next = previous.next ? previous.next.next : null;
  //   }
  // }

  insertAt(data, index) {
    if (!this.head) {
      this.head = new Node(data);
      return;
    }

    if (index === 0) {
      this.head = new Node(data, this.head);
      return;
    }

    const previous = this.getAt(index - 1) || this.getLast(); // if this.getAt(index - 1) returns a falsey value, this.getLast() will be used instead
    const node = new Node(data, previous.next);
    previous.next = node;
  }

  // // alternative for insertAt(). Only iterates through the list one time
  // insertAt(item, index) {
  //   // insert in the beginning
  //   if (!this.head || index === 0) {
  //     this.insertFirst(item);
  //     return;
  //   }

  //   let counter = 0;
  //   let previousNode;
  //   let node = this.head;

  //   while (counter < index) {
  //     // end of list / out of bound
  //     if (!node.next) {
  //       node.next = new Node(item);
  //       return;
  //     }
  //     previousNode = node;
  //     node = node.next;
  //     counter++;
  //   }

  //   // insert in the middle
  //   if (previousNode) {
  //     previousNode.next = new Node(item, node);
  //   }
  // }

  *[Symbol.iterator]() {
    let node = this.head;
    while (node) {
      yield node;
      node = node.next;
    }
  }

  forEach(fn) {
    if (!this.head) {
      return null;
    }

    let node = this.head;
    while (node) {
      fn(node);
      node = node.next;
    }
  }
}

module.exports = { Node, LinkedList };
