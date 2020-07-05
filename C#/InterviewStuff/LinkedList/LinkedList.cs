using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewStuff.LinkedList
{
    // --- Directions
    // Implement classes Node and Linked Lists
    // See 'directions' document

    public class LinkedList<T>
    {
        public Node<T> Head;

        public LinkedList()
        {
            Head = null;
        }

        public void InsertFirst(T data)
        {
            Head = new Node<T>(data, Head);
        }

        public int Size()
        {
            int counter = 0;
            Node<T> node = Head; // first node in linked list

            // when we first enter into it, if the linked list doesn't have a head node assigned to it, this loop
            // will fail the check.
            // If a head node does exist, we want to increment the counter, and then assign the node to the next node. It'll either be null signaling the current //// node is the end, or it'll be assigned to hte next node.
            while (node != null)
            {
                counter++;
                node = node.Next;
            }

            return counter;
        }

        // Size() alternative solution
        public int Size2()
        {
            int count = 0;
            if (Head == null)
            {
                return count;
            }

            Node<T> node = Head;
            for (int i = 1; node != null; i++)
            {
                node = node.Next;
                if (node == null)
                {
                    count = i;
                }
            }

            return count;
        }

        public Node<T> GetFirst()
        {
            return Head;
        }

        public Node<T> GetLast()
        {
            // check if there are any nodes first
            if (Head == null)
            {
                return null;
            }

            // need to iterate through list and get to last node
            Node<T> node = Head;
            while (node != null)
            {
                // if node.next is null, that means we're at the last node
                if (node.Next == null)
                {
                    return node;
                }
                node = node.Next;
            }

            return node;
        }

        // Shorter alternative
        public Node<T> GetLast2()
        {
            Node<T> node = Head;
            while (node.Next != null)
            {
                node = node.Next;
            }
            return node;
        }

        public void Clear()
        {
            Head = null;
        }

        public void RemoveFirst()
        {
            // check if there is a head node first
            if (Head == null)
            {
                return;
            }

            Head = Head.Next;
        }

        public void RemoveLast()
        {
            // check if there is a node
            if (Head == null)
            {
                return;
            }

            // check if there is only one node
            if (Head.Next == null)
            {
                Head = null;
                return;
            }

            Node<T> previous = Head;
            Node<T> node = Head.Next;

            // while there is a next node
            while (node.Next != null)
            {
                previous = node;
                node = node.Next;
            }
            previous.Next = null;
        }

        // Alternative
        public void RemoveLast2()
        {
            if (Size() == 0 || Size() == 1)
            {
                Head = null;
                return;
            }
            Node<T> node = Head;
            while (node != null)
            {
                if (node.Next.Next == null)
                {
                    node.Next = null;
                    return;
                }
                node = node.Next;
            }
        }

        public void InsertLast(T data)
        {
            Node<T> last = GetLast();

            if (last != null)
            {
                last.Next = new Node<T>(data); // There are some existing nodes in our chain
            }
            else
            {
                Head = new Node<T>(data); // The chain is empty!
            }
        }

        public Node<T> GetAt(int index)
        {
            int counter = 0;
            Node<T> node = Head;

            // while we have another node
            while (node != null)
            {
                if (counter == index)
                {
                    return node;
                }

                counter++;
                node = node.Next;
            }
            return null;
        }

        public void RemoveAt(int index)
        {
            if (Head == null)
            {
                return;
            }

            // if it's the first node
            if (index == 0)
            {
                Head = Head.Next;
            }

            Node<T> previous = GetAt(index - 1);
            if (previous == null || previous.Next == null)
            {
                return;
            }
            previous.Next = previous.Next.Next; // getting rid of the middle node which is previous.next
        }

        // Alternative
        public void RemoveAt2(int index)
        {
            if (index == 0)
            {
                Head = Head?.Next; // same as _head = _head != null ? _head.Next : null;
                return;
            }
            Node<T> previous = GetAt(index - 1);
            if (previous != null)
            {
                previous.Next = previous.Next?.Next; // same as previous.Next = previous.Next != null ? previous.Next.Next : null;
            }
        }

        public void InsertAt(T data, int index)
        {
            if (Head == null)
            {
                Head = new Node<T>(data);
                return;
            }

            if (index == 0)
            {
                Head = new Node<T>(data, Head);
                return;
            }

            Node<T> previous = GetAt(index - 1) ?? GetLast(); // if GetAt(index - 1) returns null, GetLast() will be used instead
            Node<T> node = new Node<T>(data, previous.Next);
            previous.Next = node;
        }

        // Alternative. Only iterates through the list one time
        public void InsertAt2(T data, int index)
        {
            // insert in the beginning
            if (Head == null || index == 0)
            {
                InsertFirst(data);
                return;
            }
            int counter = 0;
            Node<T> previousNode = null;
            Node<T> node = Head;
            while (counter < index)
            {
                // end of list / out of bound
                if (node.Next == null)
                {
                    node.Next = new Node<T>(data);
                    return;
                }
                previousNode = node;
                node = node.Next;
                counter++;
            }
            // insert in the middle
            if (previousNode != null)
            {
                previousNode.Next = new Node<T>(data, node);
            }
        }
    }

    public class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T data, Node<T> next = null)
        {
            Data = data;
            Next = next;
        }
    }
}
