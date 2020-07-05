using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewStuff
{
    // --- Directions
    // Given the root node of a tree, return
    // an array where each element is the width
    // of the tree at each level.
    // --- Example
    // Given:
    //     0
    //   / |  \
    // 1   2   3
    // |       |
    // 4       5
    // Answer: [1, 3, 2]
    public class LevelWidth
    {
        public static List<int> GetLevelWidths(Node root)
        {
            List<object> arr = new List<object>() { root, "s" };
            List<int> counters = new List<int>() { 0 }; // will hold the widths along our tree

            while (arr.Count > 1)
            {
                object node = arr.First();
                arr.RemoveAt(0);

                if (node.ToString() == "s")
                {
                    counters.Add(0);
                    arr.Add("s");
                }
                else
                {
                    arr.AddRange((node as Node).Children);
                    counters[counters.Count - 1]++; // find very last element in counters and increment by one.
                }
            }
            return counters;
        }
    }
}
