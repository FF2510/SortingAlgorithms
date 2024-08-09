namespace SortingAlgorithms
{
    /// <summary>
    /// The BubbleSort class implements the sorting algorithm "Bubble Sort"
    /// and ensures that it cannot be further derived by marking it as "sealed".
    /// </summary>
    public sealed class BubbleSort : ISortingAlgorithm
    {
        /// <summary>
        /// Sorts an array of integers in ascending order using the Bubble Sort algorithm.
        /// </summary>
        /// <param name="array">The array of integers to be sorted.</param>
        public void Sort(int[] array)
        {
            // Store the length of the array in a variable (n).
            int n = array.Length;

            // Outer loop -> Iterates through all elements of the array.
            for (int i = 0; i < n - 1; i++)
            {
                // Inner loop -> Compares neighboring elements and swaps them if they are in the wrong order.
                for (int j = 0; j < n - i - 1; j++)
                {
                    // If the current element (j) is larger than its neighbor (j + 1) in ascending order, swap them.
                    if (array[j] > array[j + 1])
                    {
                        // Swap the elements (j <-> j + 1) using the Sorting Helper library.
                        SortingHelper.Swap(array, j, j + 1);
                    }
                }
            }
        }
    }
}