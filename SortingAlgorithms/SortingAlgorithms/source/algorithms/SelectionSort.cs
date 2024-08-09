namespace SortingAlgorithms
{
    /// <summary>
    /// The SelectionSort class implements the sorting algorithm "Selection Sort"
    /// and ensures that it cannot be further derived by marking it as "sealed".
    /// </summary>
    public sealed class SelectionSort : ISortingAlgorithm
    {
        /// <summary>
        /// Sorts an array of integers in ascending order using the Selection Sort algorithm.
        /// </summary>
        /// <param name="array">The array of integers to be sorted.</param>
        public void Sort(int[] array)
        {
            // Store the length of the array in a variable (n).
            int n = array.Length;

            // Outer loop -> Loop over all elements in the array (i -> current selection).
            for (int i = 0; i < n - 1; i++)
            {
                // Assume that the smallest element is at the current selection (i).
                int s = i;

                // Inner loop -> Loop through all elements of the array, starting with the current selection.
                // (j -> candidate for the smallest element).
                for (int j = i + 1; j < n; j++)
                {
                    // Check whether the candidate element (j) is smaller than the current selection (i).
                    if (array[j] < array[s])
                    {
                        // Update smallest element (s).
                        s = j;
                    }
                }

                // If smallest element (s) is not equal to current selection (i).
                if (s != i)
                {
                    // Swap elements (s <-> i) using the Sorting Helper library.
                    SortingHelper.Swap(array, i, s);
                }
            }
        }
    }
}
