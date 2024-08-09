namespace SortingAlgorithms
{
    /// <summary>
    /// Interface that defines a method to sort an array of integers.
    /// Implementing classes will provide specific sorting algorithms.
    /// </summary>
    public interface ISortingAlgorithm
    {
        /// <summary>
        /// Sorts an array of integers in ascending order.
        /// </summary>
        /// <param name="array">The array of integers to be sorted.</param>
        void Sort(int[] array);
    }
}
