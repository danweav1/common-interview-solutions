using InterviewStuff.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewStuff
{
    // --- Directions
    // Given a linked list, return true if the list
    // is circular, false if it is not.
    // --- Examples
    //   const l = new List();
    //   const a = new Node('a');
    //   const b = new Node('b');
    //   const c = new Node('c');
    //   l.head = a;
    //   a.next = b;
    //   b.next = c;
    //   c.next = b;
    //   circular(l) // true
    public class Circular
    {
        public static bool IsCircular<T>(InterviewStuff.LinkedList.LinkedList<T> list)
        {
            Node<T> slow = list.GetFirst();
            Node<T> fast = list.GetFirst();

            // if either of the below while loop conditions is false, that means we DON'T have a circular linked list
            while (fast.Next != null && fast.Next.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                {
                    return true; // we have a circular linked list
                }
            }

            return false;
        }
    }
}
