namespace SortingAlgorithms
{
    /// <summary>
    /// The InsertionSort class implements the sorting algorithm "Insertion Sort"
    /// and ensures that it cannot be further derived by marking it as "sealed".
    /// </summary>
    public sealed class InsertionSort : ISortingAlgorithm
    {
        /// <summary>
        /// Sorts an array of integers in ascending order using the Insertion Sort algorithm.
        /// </summary>
        /// <param name="array">The array of integers to be sorted.</param>
        public void Sort(int[] array)
        {
            // Store the length of the array in a variable (n).
            int n = array.Length;
            
            // Outer loop -> Loop over all array elements (ignore first -> i = 1).
            for(int i = 1; i < n; i++)
            {
                // The value of the current element.
                int value = array[i];

                // The previous index of the current element (element -> element - 1).
                int prev = i - 1;

                // Inner loop -> Loop while not at end (prev >= 0) & previous value greater than stored value (value).
                while(prev >= 0 && array[prev] > value)
                {
                    // If previous value greater:
                    // -> Set value of index before previous to value of previous.
                    array[prev + 1] = array[prev];

                    // Move the previous index in the array down one.
                    prev--;
                }

                // If while loop completed:
                // -> Set the value of the matching position (previous + 1) to the stored value (value).
                array[prev + 1] = value;
            }
        }
    }
}