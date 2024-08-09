namespace SortingAlgorithms
{
    /// <summary>
    /// The <see cref="SortingHelper"/> class provides utility methods for operations related to sorting algorithms.
    /// This class is designed for internal use within the assembly and is not accessible outside of it.
    /// The methods in this class assist with common tasks such as swapping elements in an array, 
    /// which are frequently used in various sorting algorithms.
    /// </summary>
    internal static class SortingHelper
    {   
        /// <summary>
        /// Swaps the elements at the specified indexes in the array.
        /// </summary>
        /// <param name="array">The array containing the elements to swap.</param>
        /// <param name="a">The index of the first element.</param>
        /// <param name="b">The index of the second element.</param>
        public static void Swap(int[] array, int a, int b)
        {
            // Swap with temporary placeholder
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        /// <summary>
        /// Partitions an array into two sub-arrays around a pivot value.
        /// </summary>
        /// <param name="array">The array to be partitioned.</param>
        /// <param name="left">The left boundary of the array.</param>
        /// <param name="right">The right boundary of the array.</param>
        /// <returns>The index of the pivot element after partitioning.</returns>
        public static int Partition(int[] array, int left, int right)
        {
            // Choose the last element as the pivot.
            int pivot = array[right];

            // Start tracking the "smaller than pivot" region at the left boundary.
            int m = left;

            // Iterate over the array segment.
            for (int i = left; i < right; i++)
            {
                // If the current element is less than the pivot:
                if (array[i] < pivot)
                {
                    // Swap the current element with the element at the "smaller than pivot" region's boundary.
                    SortingHelper.Swap(array, i, m);
                    // Expand the "smaller than pivot" region.
                    m++;
                }
            }

            // Place the pivot in its correct position by swapping it with the first element of the "greater than pivot" region.
            SortingHelper.Swap(array, right, m);

            // Return the final pivot position.
            return m;
        }
        
        /// <summary>
        /// Merges two sorted sub-arrays of an integer array into a single sorted sub-array.
        /// The sub-arrays are defined by the indices [left, middle] and [middle + 1, right].
        /// The merged result is stored back into the original array.
        /// </summary>
        /// <param name="array">The array containing the sub-arrays to be merged.</param>
        /// <param name="left">The starting index of the first sub-array.</param>
        /// <param name="middle">The ending index of the first sub-array (middle point).</param>
        /// <param name="right">The ending index of the second sub-array.</param>
        public static void Merge(int[] array, int left, int middle, int right)
        {
            // Temporary array with the same size as the given array.
            int[] temp = new int[array.Length];

            // Pointer for the left part of the array.
            int leftPointer = left;

            // Pointer for the right part of the array.
            int rightPointer = middle + 1;

            // Current position (index) in the temporary array.
            int i = left;

            // Loop while either the left or right pointer is within its boundaries.
            while (leftPointer <= middle || rightPointer <= right)
            {
                // If right pointer is out of bounds or left pointer is within bounds and less than or equal to right pointer's value.
                if (rightPointer > right || (leftPointer <= middle && array[leftPointer] <= array[rightPointer]))
                {
                    // Set next array element to be value of left pointer.
                    temp[i] = array[leftPointer];
                    // Increment pointer ...
                    leftPointer++;
                }
                else
                {
                    // Set next array element to be value of right pointer.
                    temp[i] = array[rightPointer];
                    // Increment pointer ...
                    rightPointer++;
                }

                // Increment index in temporary array.
                i++;
            }

            // Copy the sorted elements from the temp array back into the original array.
            for (int j = left; j <= right; j++)
            {
                // Replace element.
                array[j] = temp[j];
            }
        }

    }
}