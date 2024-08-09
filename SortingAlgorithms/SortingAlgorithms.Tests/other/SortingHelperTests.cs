namespace SortingAlgorithms.Tests
{
    public class SortingHelerTests
    {
        [Fact]
        public void SortingHelper_SwitchArrayElements()
        {
            // Define unsorted & expected arrays
            int[] array = {1, 2};
            int[] expected = {2, 1};

            // Swap
            SortingHelper.Swap(array, 0, 1);

            // Check if successful (Assert)
            Assert.Equal(array, expected);
        }
    }
}