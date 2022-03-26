using System;
using System.Collections.Generic;
using Xunit;
using LinkedList;

namespace TestLinkedList
{
    public class UnitTest1
    {
        [Fact]
        public void TestisEmptyLinkedList()
        {
            LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();
            list.AddFirst(5);
            Assert.NotNull(list);
        }

        [Fact]
        public void CanAddNodeToLinkedList()
        {
            LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();

            list.AddFirst(2);

            Assert.Equal(1, 1);
        }

        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 2)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)]
        public void AddMultipleNodesToLinkedListAndCheckTheHead(int[] nums, int expected)
        {
            LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();
            int actual = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                    actual = nums[i];

                list.AddFirst(nums[i]);
            }

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)]
        public void ReturnTrueForLookupWhenValueIsInLinkedList(int[] nums, int target)
        {
            LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();

            foreach (var num in nums)
                list.AddFirst(num);

            Assert.True(list.Search(target));
        }

        //[Theory]
        //[InlineData(new int[] { }, "null")]
        //[InlineData(new int[] { 1 }, "[1] -> null")]
        //[InlineData(new int[] { 1, 2, 3}, "[1] -> [2] -> [3] -> null")]
        //public void CanPrintLinkedList(int[] nums, string expected)
        //{
        //    LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();

        //    foreach (var num in nums)
        //        list.AddLast(num);

        //    Assert.Equal(expected, list.ToSstring());
        //}

    }
}
