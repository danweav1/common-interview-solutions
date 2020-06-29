using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.ExceptionServices;
using System.Text;

namespace InterviewStuff
{
    // --- Directions
    // Implement a Queue datastructure using two stacks.
    // *Do not* create an array inside of the 'Queue' class.
    // Queue should implement the methods 'add', 'remove', and 'peek'.
    // For a reminder on what each method does, look back
    // at the Queue exercise.
    // --- Examples
    //     const q = new Queue();
    //     q.add(1);
    //     q.add(2);
    //     q.peek();  // returns 1
    //     q.remove(); // returns 1
    //     q.remove(); // returns 2

    public class QFromS<T>
    {
        private readonly Stack<T> first;
        private readonly Stack<T> second;

        public QFromS()
        {
            first = new Stack<T>();
            second = new Stack<T>();
        }

        public void Add(T record)
        {
            first.Push(record);
        }

        public T Remove()
        {
            while (first.Count > 0)
            {
                T recordToPop = first.Pop();
                second.Push(recordToPop);
            }

            T record = second.Pop();

            while (second.Count > 0)
            {
                T recordToPop = second.Pop();
                first.Push(recordToPop);
            }

            return record;
        }

        public T Peek()
        {
            while (first.Count > 0)
            {
                second.Push(first.Pop());
            }

            T record = second.Peek();

            while (second.Count > 0)
            {
                first.Push(second.Pop());
            }

            return record;
        }
    }
}
