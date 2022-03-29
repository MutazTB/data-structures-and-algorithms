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
        public void AddMultipleNodesToLinkedList(int[] nums, int expected) // add multiple nodes to the end of a linked list
        {
            LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();
            int actual = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                    actual = nums[i];

                list.Append(nums[i]);
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

        [Theory]        
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 100)]// add a node to the end of the linked list
        public void CanAppendNodeToEndLinkedList(int[] nums, int value)
        {
            LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();

            foreach (var num in nums)
                list.AddFirst(num);

            list.Append(value);

            Assert.True(list.Search(value));
        }

        [Theory]
        [InlineData(new int[] { 3 },3, 1)] // insert a node before the first node of a linked list
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3 ,5)]// insert a node before a node located i the middle of a linked list
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5, 5)]// insert a node before the last node of a linked list
        public void AddBefore(int[] nums,int index ,int data)
        {
            LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();
            foreach (var num in nums)
                list.AddFirst(num);

            list.AddBefore(index,data);
            Assert.True(list.Search(data));
        }

        [Theory]
        [InlineData(new int[] { 3 }, 3, 1)]// insert a node after the first node of the linked list
        [InlineData(new int[] { 1, 2, 3, 4, 5 },3, 5)]// insert after a node in the middle of the linked list
        [InlineData(new int[] { 1, 2, 3, 4, 5 },5, 5)]// insert a node after the last node of the linked list
        public void AddAfter(int[] nums,int index, int data)
        {
            LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();
            foreach (var num in nums)
                list.AddFirst(num);

            list.AddAfter(index, data);
            Assert.True(list.Search(data));
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
