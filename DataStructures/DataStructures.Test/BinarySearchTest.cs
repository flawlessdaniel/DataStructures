using DataStructures;
using Xunit;

namespace DataStructures.Test
{
    public class BinarySearchTest
    {
        [Fact]
        public void BinarySearch_Sorted_Array()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            Assert.Equal(2, BinarySearch.SearchIterable(array, 3));
            Assert.Equal(4, BinarySearch.SearchIterable(array, 5));
            Assert.Equal(7, BinarySearch.SearchIterable(array, 8));
            Assert.Equal(10, BinarySearch.SearchIterable(array, 11));

            Assert.Equal(2, BinarySearch.SearchRecursively(array, 3));
            Assert.Equal(4, BinarySearch.SearchRecursively(array, 5));
            Assert.Equal(7, BinarySearch.SearchRecursively(array, 8));
            Assert.Equal(10, BinarySearch.SearchRecursively(array, 11));
        }
    }
}