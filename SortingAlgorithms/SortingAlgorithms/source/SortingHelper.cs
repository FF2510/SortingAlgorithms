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
        public static void Switch(int[] array, int a, int b)
        {
            // Swap with temporary placeholder
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}