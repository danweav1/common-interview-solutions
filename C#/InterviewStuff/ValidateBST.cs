using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewStuff
{
    // --- Directions
    // Given a node, validate the binary search tree,
    // ensuring that every node's left hand child is
    // less than the parent node's value, and that
    // every node's right hand child is greater than
    // the parent
    public class ValidateBST
    {
        public static bool Validate(BinarySearchTreeNode node, int? min = null, int? max = null)
        {
            // haven't yet set a max bound AND we have a max value but the current node is out of bounds of that value, then something is wrong
            if (max != null && node.Data > max)
            {
                return false;
            }

            // same as above but for min
            if (min != null && node.Data < min)
            {
                return false;
            }

            // if there is a node on the left, and calling validate on that node returns false, then something went wrong
            if (node.Left != null && !Validate(node.Left, min, node.Data))
            {
                return false;
            }

            // same as above but for right side
            if (node.Right != null && !Validate(node.Right, node.Data, max))
            {
                return false;
            }

            return true;
        }

        // Alternate solution using math.min and max
        public static bool Validate2(BinarySearchTreeNode node, int min = int.MinValue, int max = int.MaxValue)
        {
            if (node.Data <= min || node.Data >= max) return false;
            if (node.Left != null) return Validate2(node.Left, min, node.Data);
            if (node.Right != null) return Validate2(node.Right, node.Data, max);
            return true;
        }
    }
}
