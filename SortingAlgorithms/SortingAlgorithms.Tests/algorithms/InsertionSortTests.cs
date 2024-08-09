namespace SortingAlgorithms.Tests
{
    public class InsertionSortTests
    {
        [Fact]
        public void InsertionSort_SortArray()
        {
            // Define unsorted & expected arrays
            int[] actual = {5, 3, 1, 4, 2};
            int[] expected = {1, 2, 3, 4, 5};

            // Create new sorter
            ISortingAlgorithm sorter = new InsertionSort();

            // Sort unsorted array (Act)
            sorter.Sort(actual);

            // Check if successful (Assert)
            Assert.Equal(expected, actual);
        }
    }
}