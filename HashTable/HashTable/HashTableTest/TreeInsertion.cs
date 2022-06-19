using HashTable;
using Hashtables;
using System;
using System.Collections.Generic;
using Xunit;

namespace HashTableTest
{
    public class TreeInsertion
    {
        [Fact]
        public void Test1()
        {
            Node n1 = new Node("Real Madrid", "14");
            Node n2 = new Node("AcMilan", "7");
            Node n3 = new Node("FC Bayern München", "6");
            Node n4 = new Node("Liverpool FC", "5");
            Node n5 = new Node("Inter", "2");
            Node n15 = new Node("2", "2");
            Node n16 = new Node("5", "5");
            Node n17 = new Node("7", "8");
            Node n18 = new Node("1", "1");

            BinaryTree tree1 = new BinaryTree(n5);
            tree1.Root.Left = n2;
            tree1.Root.Right = n3;
            tree1.Root.Left.Right = n4;

            BinaryTree tree2 = new BinaryTree(n15);
            tree2.Root.Left = n16;
            tree2.Root.Right = n17;
            tree2.Root.Right.Left = n18;

            List<string> expected = new List<string> { "5","2" };
            List<string> actual = Program.TreeIntersection(tree1, tree2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            Node n1 = new Node("Real Madrid", "14");
            Node n2 = new Node("AcMilan", "7");
            Node n3 = new Node("FC Bayern München", "6");
            Node n4 = new Node("Liverpool FC", "5");
            Node n5 = new Node("Inter", "2");
            Node n15 = new Node("2", "2");
            Node n16 = new Node("5", "5");
            Node n17 = new Node("7", "7");
            Node n18 = new Node("1", "1");

            BinaryTree tree1 = new BinaryTree(n5);
            tree1.Root.Left = n2;
            tree1.Root.Right = n3;
            tree1.Root.Left.Right = n4;

            BinaryTree tree2 = new BinaryTree(n15);
            tree2.Root.Left = n16;
            tree2.Root.Right = n17;
            tree2.Root.Right.Left = n18;

            List<string> expected = new List<string> { "5","2","7" };
            List<string> actual = Program.TreeIntersection(tree1, tree2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            Node n1 = new Node("Real Madrid", "14");
            Node n2 = new Node("AcMilan", "9");
            Node n3 = new Node("FC Bayern München", "6");
            Node n4 = new Node("Liverpool FC", "10");
            Node n5 = new Node("Inter", "8");
            Node n15 = new Node("2", "2");
            Node n16 = new Node("5", "5");
            Node n17 = new Node("7", "7");
            Node n18 = new Node("1", "1");

            BinaryTree tree1 = new BinaryTree(n5);
            tree1.Root.Left = n2;
            tree1.Root.Right = n3;
            tree1.Root.Left.Right = n4;

            BinaryTree tree2 = new BinaryTree(n15);
            tree2.Root.Left = n16;
            tree2.Root.Right = n17;
            tree2.Root.Right.Left = n18;

            List<string> expected = new List<string>();
            List<string> actual = Program.TreeIntersection(tree1, tree2);

            Assert.Equal(expected, actual);
        }
    }
}
