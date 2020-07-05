using InterviewStuff.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewStuff
{
    // --- Directions
    // Return the 'middle' node of a linked list.
    // If the list has an even number of elements, return
    // the node at the end of the first half of the list.
    // *Do not* use a counter variable, *do not* retrieve
    // the size of the list, and only iterate
    // through the list one time.
    // --- Example
    //   const l = new LinkedList();
    //   l.insertLast('a')
    //   l.insertLast('b')
    //   l.insertLast('c')
    //   midpoint(l); // returns { data: 'b' }
    public class Midpoint<T>
    {
        public static Node<T> GetMidPoint(LinkedList.LinkedList<T> linkedList)
        {
            if (linkedList.GetFirst() == null)
            {
                return null;
            }
            Node<T> slow = linkedList.GetFirst();
            Node<T> fast = linkedList.GetFirst();

            // fast moves twice as much through the nodes as slow, so at the end, when fast does not have two nodes ahead of it, slow will be at the midpoint
            while (fast.Next != null && fast.Next.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow;
        }
    }
}
