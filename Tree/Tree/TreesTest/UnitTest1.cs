using System;
using Xunit;
using Tree;
using System.Collections.Generic;

namespace TreesTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanSuccessfullyInstantiateAnEmptyTree()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();

            Assert.NotNull(binarySearchTree);
        }

        [Fact]
        public void CanSuccessfullyInstantiateATreeWithASingleRoot()
        {
            Node node = new Node(5);
            BinarySearchTree binarySearchTree = new BinarySearchTree(node);

            Assert.NotNull(binarySearchTree);
            Assert.Equal(5, binarySearchTree.Root.Value);
        }

        [Fact]
        public void CanSuccessfullyAddALeftChildAndRightchildToASingleRootNode()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();

            binarySearchTree.Root = new Node(10);
            binarySearchTree.Root.Left = new Node(5);
            binarySearchTree.Root.Right = new Node(15);

            Assert.Equal(10, binarySearchTree.Root.Value);
            Assert.Equal(5, binarySearchTree.Root.Left.Value);
            Assert.Equal(15, binarySearchTree.Root.Right.Value);
        }

        [Fact]
        public void CanSuccessfullyReturnACollectionFromAPreorderTraversal()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            BinaryTree tree1 = new BinaryTree(n1);
            tree1.Root.Left = n2;
            tree1.Root.Right = n3;
            tree1.Root.Left.Left = n4;
            tree1.Root.Left.Right = n5;

            Assert.Equal(new List<int> { 1, 2, 4 , 5 , 3 }, tree1.PreOrder(tree1.Root));
        }


        [Fact]
        public void CanSuccessfullyReturnACollectionFromAnInorderTraversal()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            BinaryTree tree1 = new BinaryTree(n1);
            tree1.Root.Left = n2;
            tree1.Root.Right = n3;
            tree1.Root.Left.Left = n4;
            tree1.Root.Left.Right = n5;

            Assert.Equal(new List<int> { 4 , 2, 5, 1 ,3 }, tree1.InOrder(tree1.Root));
        }


        [Fact]
        public void CanSuccessfullyReturnACollectionFromAPostorderTraversal()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            BinaryTree tree1 = new BinaryTree(n1);
            tree1.Root.Left = n2;
            tree1.Root.Right = n3;
            tree1.Root.Left.Left = n4;
            tree1.Root.Left.Right = n5;

            Assert.Equal(new List<int> { 4 , 5, 2 , 3 , 1 }, tree1.PostOrder(tree1.Root));
        }

        [Fact]
        public void CanSuccessfullyAddValuesToATree()
        {
            Node n1 = new Node(10);
            Node n2 = new Node(20);
            Node n3 = new Node(30);

            BinarySearchTree binarySearchTree = new BinarySearchTree(n1);
                        
            binarySearchTree.Add(n2);
            binarySearchTree.Add(n3);

            Assert.Equal(10, binarySearchTree.Root.Value);
            Assert.Equal(20, binarySearchTree.Root.Right.Value);
            Assert.Equal(30, binarySearchTree.Root.Right.Right.Value);
        }

        [Fact]
        public void CanSuccessfullyCheckIfTheTreeContainsAValue()
        {
            Node n1 = new Node(10);
            Node n2 = new Node(20);
            Node n3 = new Node(30);

            BinarySearchTree binarySearchTree = new BinarySearchTree(n1);

            binarySearchTree.Add(n2);
            binarySearchTree.Add(n3);

            Assert.True(binarySearchTree.Contains(10));
            Assert.True(binarySearchTree.Contains(20));
            Assert.True(binarySearchTree.Contains(30));            
        }

        
        [Fact]
        public void maxValueintree()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            BinaryTree tree1 = new BinaryTree(n1);
            tree1.Root.Left = n2;
            tree1.Root.Right = n3;
            tree1.Root.Left.Left = n4;
            tree1.Root.Left.Right = n5;

            Assert.Equal(5, tree1.findMax(tree1.Root));
        }
        [Fact]
        public void maxValueinTreeWithSameValueForMoreThanOneNode()
        {
            Node n1 = new Node(5);
            Node n2 = new Node(5);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            BinaryTree tree1 = new BinaryTree(n1);
            tree1.Root.Left = n2;
            tree1.Root.Right = n3;
            tree1.Root.Left.Left = n4;
            tree1.Root.Left.Right = n5;

            Assert.Equal(5, tree1.findMax(tree1.Root));
        }
    }
}
