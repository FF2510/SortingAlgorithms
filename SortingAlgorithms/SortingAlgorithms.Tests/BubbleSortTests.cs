namespace SortingAlgorithms.Tests
{
    public class BubbleSortTests
    {
        [Fact]
        public void BubbleSort_SortArray()
        {
            // Define unsorted & expected arrays
            int[] array = {5, 3, 1, 4, 2};
            int[] expected = {1, 2, 3, 4, 5};

            // Create new sorter
            ISortingAlgorithm sorter = new BubbleSort();

            // Sort unsorted array (Act)
            sorter.Sort(array);

            // Check if successful (Assert)
            Assert.Equal(array, expected);
        }
    }
}