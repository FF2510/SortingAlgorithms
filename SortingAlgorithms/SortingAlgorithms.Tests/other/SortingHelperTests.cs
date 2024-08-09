namespace SortingAlgorithms.Tests
{
    public class SortingHelerTests
    {
        [Fact]
        public void SortingHelper_SwapArrayElements()
        {
            // Define unsorted & expected arrays
            int[] actual = {1, 2};
            int[] expected = {2, 1};

            // Swap
            SortingHelper.Swap(actual, 0, 1);

            // Check if successful (Assert)
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SortingHelper_PartitionArray()
        {
            // Arrange
            int[] array = { 9, 4, 6, 2, 8, 7, 5, 3, 1 };
            int left = 0;
            int right = array.Length - 1;

            // Act
            int pivotIndex = SortingHelper.Partition(array, left, right);

            // Assert
            Assert.All(array[..pivotIndex], x => Assert.True(x < array[pivotIndex])); // All elements on the left of the pivot should be less than the pivot
            Assert.All(array[(pivotIndex + 1)..], x => Assert.True(x >= array[pivotIndex])); // All elements on the right of the pivot should be greater than or equal to the pivot
        }

        [Fact]
        public void SortingHelper_MergeArrays()
        {
            // Arrange
            int[] array = { 1, 3, 5, 2, 4, 6 };
            int[] expected = { 1, 2, 3, 4, 5, 6 };
            int left = 0;
            int middle = 2;  // Middle index splits array into [1, 3, 5] and [2, 4, 6]
            int right = array.Length - 1;

            // Act
            SortingHelper.Merge(array, left, middle, right);

            // Assert
            Assert.Equal(expected, array); // Verify that the merged array matches the expected sorted array
        }

        [Fact]
        public void SortingHelper_IsSorted()
        {
            // Define the sorted array
            int[] array = {1, 2, 3, 4, 5};
            // Define the expected result
            bool expected = true;

            // Use method to check array
            bool actual = SortingHelper.IsSorted(array);

            // Check if successful (Assert)
            Assert.Equal(expected, actual);
        }
    }
}