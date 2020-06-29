using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewStuff.Weave
{
    // --- Directions
    // 1) Complete the task in weave/queue.js
    // 2) Implement the 'weave' function.  Weave
    // receives two queues as arguments and combines the
    // contents of each into a new, third queue.
    // The third queue should contain the *alterating* content
    // of the two queues.  The function should handle
    // queues of different lengths without inserting
    // 'undefined' into the new one.
    // *Do not* access the array inside of any queue, only
    // use the 'add', 'remove', and 'peek' functions.
    // --- Example
    //    const queueOne = new Queue();
    //    queueOne.add(1);
    //    queueOne.add(2);
    //    const queueTwo = new Queue();
    //    queueTwo.add('Hi');
    //    queueTwo.add('There');
    //    const q = weave(queueOne, queueTwo);
    //    q.remove() // 1
    //    q.remove() // 'Hi'
    //    q.remove() // 2
    //    q.remove() // 'There'
    public static class Weave
    {
        // Note: this is different than the javascript version because we have Types in C#. A queue can't hold two different types, so
        // I'm just using a string for the Type. Another solution is to have the Queue class inherit from a certain interface and 
        // set this return type to Queue<some-interface>.
        public static Queue<string> DoWeave<T1, T2>(Queue<T1> sourceOne, Queue<T2> sourceTwo)
        {
            Queue<string> q = new Queue<string>();

            // Note: we aren't using .Peek here like in the javascript version because javascript won't throw an error if the collection is empty, 
            // it just uses a truthy or falsey value. We have to use .Count in C#.
            while (sourceOne.Count > 0 || sourceTwo.Count > 0)
            {
                if (sourceOne.Peek() != null)
                {
                    q.Add(sourceOne.Remove().ToString());
                }

                if (sourceTwo.Peek() != null)
                {
                    q.Add(sourceTwo.Remove().ToString());
                }
            }

            return q;
        }
    }
}
