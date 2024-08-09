namespace SortingAlgorithms.Tests
{
    public class MergeSortTests
    {
        [Fact]
        public void MergeSort_SortArray()
        {
            // Define unsorted & expected arrays
            int[] actual = {5, 3, 1, 4, 2};
            int[] expected = {1, 2, 3, 4, 5};

            // Create new sorter
            ISortingAlgorithm sorter = new MergeSort();

            // Sort unsorted array (Act)
            sorter.Sort(actual);

            // Check if successful (Assert)
            Assert.Equal(expected, actual);
        }
    }
}