namespace SortingAlgorithms
{
    /// <summary>
    /// The QuickSort class implements the sorting algorithm "Quick Sort"
    /// and ensures that it cannot be further derived by marking it as "sealed".
    /// </summary>
    public sealed class QuickSort : ISortingAlgorithm
    {
        /// <summary>
        /// Sorts an array of integers in ascending order using the Quick Sort algorithm.
        /// </summary>
        /// <param name="array">The array of integers to be sorted.</param>
        public void Sort(int[] array)
        {
            // Initiates the recursive QuickSort process ...
            RecursiveSort(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Recursively sorts the array using the Quick Sort algorithm.
        /// </summary>
        /// <param name="array">The array of integers to be sorted.</param>
        /// <param name="left">The left boundary of the current sub-array.</param>
        /// <param name="right">The right boundary of the current sub-array.</param>
        private static void RecursiveSort(int[] array, int left, int right)
        {
            // Ensure the segment has more than one element (min. 2).
            if (left < right)
            {
                // Partition the array and get the pivot index ...
                int pivotIndex = SortingHelper.Partition(array, left, right);

                // Recursively sort the elements before the pivot (Left segment).
                RecursiveSort(array, left, pivotIndex - 1);
                // Recursively sort the elements after the pivot (Right segment).
                RecursiveSort(array, pivotIndex + 1, right);
            }
        }
    }
}