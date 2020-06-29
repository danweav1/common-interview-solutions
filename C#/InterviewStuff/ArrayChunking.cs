using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewStuff
{
    // --- Directions
    // Given an array and chunk size, divide the array into many subarrays
    // where each subarray is of length size. Any extra numbers are put into their own array.
    // --- Examples
    // chunk([1, 2, 3, 4], 2) --> [[ 1, 2], [3, 4]]
    // chunk([1, 2, 3, 4, 5], 2) --> [[ 1, 2], [3, 4], [5]]
    // chunk([1, 2, 3, 4, 5, 6, 7, 8], 3) --> [[ 1, 2, 3], [4, 5, 6], [7, 8]]
    // chunk([1, 2, 3, 4, 5], 4) --> [[ 1, 2, 3, 4], [5]]
    // chunk([1, 2, 3, 4, 5], 10) --> [[ 1, 2, 3, 4, 5]]
    public class ArrayChunking
    {
        // Solution 1
        public static List<List<T>> Chunk1<T>(List<T> array, int size) //maybe T[] 
        {
            List<List<T>> chunks = new List<List<T>>();
            for (int i = 0; i < array.Count; i += size)
            {
                chunks.Add(array.GetRange(i, Math.Min(size, array.Count - i)));
            }

            return chunks;
        }

        // Solution 2 - using linq. Not good for performance critical code.
        public static List<List<T>> Chunk2<T>(List<T> array, int size) //maybe T[] 
        {
            List<List<T>> chunks = new List<List<T>>();

            while(array.Any())
            {
                chunks.Add(array.Take(size).ToList());
                array = array.Skip(size).ToList();
            }

            return chunks;
        }
    }
}
