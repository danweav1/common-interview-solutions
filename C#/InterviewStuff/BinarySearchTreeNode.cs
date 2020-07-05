using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewStuff
{
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
    public class BinarySearchTreeNode
    {
        public int Data;
        public BinarySearchTreeNode Left;
        public BinarySearchTreeNode Right;

        public BinarySearchTreeNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

        public void Insert(int data)
        {
            // the data should go where there is already a node, delegate it the insertion to the existing node
            if (data < Data && Left != null)
            {
                Left.Insert(data); // node already exists at left, so it should handle the insertion
            }
            else if (data < Data)
            {
                Left = new BinarySearchTreeNode(data);
            }
            else if (data > Data && Right != null)
            {
                Right.Insert(data); // node already exists at right, so it should handle the insertion
            }
            else if (data > Data)
            {
                Right = new BinarySearchTreeNode(data);
            }
        }

        // remember, if the node you are looking for is less than the root node, you DON'T have to traverse the right side. vice versa for a node greater than
        // the root node
        public BinarySearchTreeNode Contains(int data)
        {
            if (data == Data)
            {
                return this; // current node is equal to the value we're looking for
            }

            // if the data we're looking for is greater than the current node's data, check the right hand side and make sure there IS a node on the right
            if (data > Data && Right != null)
            {
                return Right.Contains(data);
            }
            else if (data < Data && Left != null)
            {
                // data we are looking for is on left hand side
                return Left.Contains(data);
            }

            return null; // if we don't find the node we're looking for
        }
    }
}
