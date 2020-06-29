using System;

namespace InterviewStuff
{
    // --- Directions
    // Write a function that accepts an integer N
    // and returns a NxN spiral matrix.
    // --- Examples
    //   matrix(2)
    //     [[1, 2],
    //     [4, 3]]
    //   matrix(3)
    //     [[1, 2, 3],
    //     [8, 9, 4],
    //     [7, 6, 5]]
    //  matrix(4)
    //     [[1,   2,  3, 4],
    //     [12, 13, 14, 5],
    //     [11, 16, 15, 6],
    //     [10,  9,  8, 7]]
    public class Matrix
    {
        public static void DoMatrix(int n)
        {
            int[][] results = new int[n][];

            //List<List<int>> results = new List<List<int>>();

            // first create the right amount of inner lists
            for (int i = 0; i < n; i++)
            {
                results[i] = new int[n];
            }

            // create a counter. this will be equal to the number we are trying to enter into the array
            int counter = 1;

            // start row and column will always be index 0
            // end row and column will always be index n - 1
            int startColumn = 0;
            int endColumn = n - 1;
            int startRow = 0;
            int endRow = n - 1;

            // these are not fixed values, they will change over time to indicate which row/column we are currently working on
            while (startColumn <= endColumn && startRow <= endRow)
            {
                // loop from start column to end column. The first for loop will always be responsible for assembling the top row of our solution.
                for (int i = startColumn; i <= endColumn; i++)
                {
                    results[startRow][i] = counter;
                    counter++;
                }
                startRow++;

                // the next for loop will be responsible for making the right hand column starting at the next row to the last row
                for (int i = startRow; i <= endRow; i++)
                {
                    results[i][endColumn] = counter;
                    counter++;
                }

                endColumn--; // finished with the last column, so decrement it

                // for the bottom row values.
                for (int i = endColumn; i >= startColumn; i--)
                {
                    results[endRow][i] = counter;
                    counter++;
                }

                endRow--; // we're finished with end row, so decrement it

                // for the starting column remaining values
                for (int i = endRow; i >= startRow; i--)
                {
                    results[i][startColumn] = counter;
                    counter++;
                }

                startColumn++; // done with start column, so move to the right
            }

            for (int i = 0; i < results.Length; i++)
            {
                foreach (var item in results[i])
                {
                    Console.Write(item.ToString() + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
