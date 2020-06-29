using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace InterviewStuff
{
    // LIFO
    // --- Directions
    // Create a stack data structure.  The stack
    // should be a class with methods 'push', 'pop', and
    // 'peek'.  Adding an element to the stack should
    // store it until it is removed.
    // --- Examples
    //   const s = new Stack();
    //   s.push(1);
    //   s.push(2);
    //   s.pop(); // returns 2
    //   s.pop(); // returns 1

    public class Stack<T>
    {
        private T[] _array;
        private int _size;
        private const int DefaultCapacity = 4;

        public Stack()
        {
            _array = Array.Empty<T>();
        }

        public Stack(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException();
            _array = new T[capacity];
        }

        public int Count
        {
            get { return _size; }
        }

        public T Pop()
        {
            int size = _size - 1;
            T[] array = _array;

            if ((uint)size >= (uint)array.Length)
            {
                throw new InvalidOperationException();
            }

            _size = size;
            T item = array[size];

            return item;
        }

        public T Peek()
        {
            int size = _size - 1;
            T[] array = _array;

            if ((uint)size >= (uint)array.Length)
            {
                throw new InvalidOperationException();
            }

            return array[size];
        }

        public void Push(T item)
        {
            int size = _size;
            T[] array = _array;

            if ((uint)size < (uint)array.Length)
            {
                array[size] = item;
                _size = size + 1;
            }
            else
            {
                PushWithResize(item);
            }
        }

        private void PushWithResize(T item)
        {
            Array.Resize(ref _array, (_array.Length == 0) ? DefaultCapacity : 2 * _array.Length);
            _array[_size] = item;
            _size++;
        }
    }
}
