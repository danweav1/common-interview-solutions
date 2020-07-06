using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewStuff
{
    // --- Directions
    // Implement bubbleSort, selectionSort, and mergeSort
    // assuming arr is a list of numbers
    public class Sorting
    {
        // worst case is n^2
        public static List<int> BubbleSort(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int lesser = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = lesser;
                    }
                }
            }

            // return the sorted array
            return list;
        }

        // worst case is n^2
        public static List<int> SelectionSort(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int indexOfMin = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[indexOfMin])
                    {
                        indexOfMin = j;
                    }
                }

                if (indexOfMin != i)
                {
                    int lesser = list[indexOfMin];
                    list[indexOfMin] = list[i];
                    list[i] = lesser;
                }
            }

            return list;
        }

        // worst case is n*log(n)
        public static List<int> MergeSort(List<int> list)
        {
            // first check if the array only has one element
            if (list.Count == 1)
            {
                return list;
            }

            // divide the array into two equal halfs
            // find the center of the array
            int center = (int)Math.Floor((double)list.Count / 2); // i.e. a length of four will give us the center at index 2; a b c d, c would be the center
            List<int> left = list.GetRange(0, center);  // take everything from index 0 up to but not including the center value;
            List<int> right = list.GetRange(center, list.Count - center); // take everything from the center index to the end of the array

            // recursively call the mergeSort algorithm on both halves
            return Merge(MergeSort(left), MergeSort(right));
        }

        public static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> results = new List<int>();

            // while there are still elements in both arrays
            while (left.Count != 0 && right.Count != 0)
            {
                if (left[0] < right[0])
                {
                    results.Add(left[0]); // remove first element in left and add it to results
                    left.RemoveAt(0);
                }
                else
                {
                    results.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            results.AddRange(left);
            results.AddRange(right);
            return results;
        }
    }
}
