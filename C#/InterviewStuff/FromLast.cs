using InterviewStuff.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewStuff
{
    // --- Directions
    // Given a linked list, return the element n spaces
    // from the last node in the list.  Do not call the 'size'
    // method of the linked list.  Assume that n will always
    // be less than the length of the list.
    // --- Examples
    //    const list = new List();
    //    list.insertLast('a');
    //    list.insertLast('b');
    //    list.insertLast('c');
    //    list.insertLast('d');
    //    fromLast(list, 2).data // 'b'
    public class FromLast
    {
        public static Node<T> GetFromLast<T>(InterviewStuff.LinkedList.LinkedList<T> list, int n)
        {
            Node<T> slow = list.GetFirst();
            Node<T> fast = list.GetFirst();

            // could use a for loop as well
            while (n > 0)
            {
                fast = fast.Next;
                n--;
            }

            // while there's still a next node to visit
            while (fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            return slow;
        }

        // Alternative
        public static Node<T> GetFromLast2<T>(InterviewStuff.LinkedList.LinkedList<T> list, int n)
        {
            Node<T> slow = list.GetAt(0);
            Node<T> fast = list.GetAt(n);

            // while there's still a next node to visit
            while (fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            return slow;
        }
    }
}
