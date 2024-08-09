namespace SortingAlgorithms
{
    /// <summary>
    /// The BogoSort class implements the "Bogo Sort" algorithm.
    /// It randomly shuffles the array until it is sorted.
    /// Please do not use this sorting algorithm for any serious sorting matters!
    /// </summary>
    public sealed class BogoSort : ISortingAlgorithm
    {
        // Random class used to randomize array elements.
        private static Random rnd = new Random();

        /// <summary>
        /// Sorts an array of integers by randomly shuffling the order of array elements using Bogo Sort.
        /// Please do not use this sorting algorithm for any serious sorting matters!
        /// </summary>
        /// <param name="array">The array of integers to be sorted.</param>
        public void Sort(int[] array)
        {
            // Shuffle the array until it is sorted.
            while (!SortingHelper.IsSorted(array))
            {
                Shuffle(array);
            }
        }

        /// <summary>
        /// Randomizes the order of array elements.
        /// </summary>
        /// <param name="array">The array to shuffle.</param>
        private static void Shuffle(int[] array)
        {
            // Loop through each element in the array.
            for (int i = 0; i < array.Length; i++)
            {
                // Select a random index between the current position and the end of the array.
                int index = rnd.Next(i, array.Length);

                // Swap the current element with the randomly selected element.
                SortingHelper.Swap(array, i, index);
            }
        }
    }
}
