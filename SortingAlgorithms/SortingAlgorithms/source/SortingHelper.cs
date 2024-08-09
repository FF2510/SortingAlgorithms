using System.Data;

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

    }
}