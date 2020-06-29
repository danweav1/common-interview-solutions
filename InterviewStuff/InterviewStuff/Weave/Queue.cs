using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewStuff.Weave
{
    // FIFO
    // --- Directions
    // Implement a 'peek' method in this Queue class.
    // Peek should return the last element (the next
    // one to be returned) from the queue *without*
    // removing it.
    public class Queue<T>
    {
        private readonly Node<T> HeadNode = new Node<T>(default(T));

        private readonly Node<T> _head;
        private Node<T> _tail;

        public Queue()
        {
            _head = HeadNode;
            _tail = _head;
        }

        public int Count { get; private set; }

        public void Add(T value)
        {
            _tail = _tail.Add(value);
            Count++;
        }

        public T Remove()
        {
            Count--;
            return _head.Remove();
        }

        public T Peek()
        {
            return GetValues().First();
        }

        public override string ToString()
        {
            return string.Join(" ", GetValues().Select(v => v.ToString()));
        }

        private IEnumerable<T> GetValues()
        {
            var current = _head.Next;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        #region Node

        private class Node<TNode>
        {
            public Node(T value)
            {
                Value = value;
            }
            public T Value { get; }
            public Node<T> Next { get; private set; }

            public Node<T> Add(T value)
            {
                Next = new Node<T>(value);
                return Next;
            }

            public T Remove()
            {
                if (Next == null)
                {
                    throw new InvalidOperationException();
                }
                var ret = Next.Value;
                Next = Next.Next;
                return ret;
            }
        }
        #endregion 
    }
}
