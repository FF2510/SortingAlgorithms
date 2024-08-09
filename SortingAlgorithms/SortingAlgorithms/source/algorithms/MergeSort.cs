namespace SortingAlgorithms
{
    /// <summary>
    /// The MergeSort class implements the sorting algorithm "Merge Sort"
    /// and ensures that it cannot be further derived by marking it as "sealed".
    /// </summary>
    public sealed class MergeSort : ISortingAlgorithm
    {
        /// <summary>
        /// Sorts an array of integers in ascending order using the Merge Sort algorithm.
        /// </summary>
        /// <param name="array">The array of integers to be sorted.</param>
        public void Sort(int[] array)
        {
            // Initiates the recursive MergeSort process.
            RecursiveSort(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Recursively sorts the array using the Merge Sort algorithm.
        /// </summary>
        /// <param name="array">The array of integers to be sorted.</param>
        /// <param name="left">The left boundary of the current sub-array.</param>
        /// <param name="right">The right boundary of the current sub-array.</param>
        private static void RecursiveSort(int[] array, int left, int right)
        {
            // Ensure the segment has more than one element (min. 2).
            if(left < right)
            {
                // Calculate the middle of the segment.
                int middle = (left + right) / 2;

                // Recursively sort the left segment.
                RecursiveSort(array, left, middle);
                // Recursively sort the right segment.
                RecursiveSort(array, middle + 1, right);
                // Merge the sorted segments back together.
                SortingHelper.Merge(array, left, middle, right);
            }
        }
    }
}