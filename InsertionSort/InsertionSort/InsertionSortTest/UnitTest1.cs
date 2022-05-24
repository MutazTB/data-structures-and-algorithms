using InsertionSort;
using System;
using Xunit;

namespace InsertionSortTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 4, 8, 15, 16, 23, 42 })]
        [InlineData(new int[] { 20, 18, 12, 8, 5, -2 })]
        [InlineData(new int[] { 5, 12, 7, 5, 5, 7 })]
        [InlineData(new int[] { 2, 3, 5, 7, 13, 11 })]
        public void InsertionSortTest(int [] arr)
        {            
            Assert.Equal(arr, Program.InsertionSort(arr));
        }        

    }
}
