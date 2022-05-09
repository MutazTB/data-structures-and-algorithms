using System;
using System.Collections.Generic;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Node n1 = new Node(2);
            Node n2 = new Node(9);
            Node n3 = new Node(5);
            Node n4 = new Node(15);
            Node n5 = new Node(30);           

            BinaryTree tree1 = new BinaryTree(n1);
            tree1.Root.Left = n2;
            tree1.Root.Right = n3;
            tree1.Root.Left.Left = n4;
            tree1.Root.Left.Right = n5;

            Console.WriteLine("Pre order ==> Root    Left    Right");// 1 2 4 5 3
            Print(tree1.PreOrder(tree1.Root));
            Console.WriteLine();

            tree1.Values.Clear();
            Console.WriteLine("In oredr ==> Left    Root    Right"); // 4 2 5 1 3
            Print(tree1.InOrder(tree1.Root));
            Console.WriteLine();
            
            tree1.Values.Clear();
            Console.WriteLine("Post order ==> Left    Right    Root"); // 4 5 2 3 1
            Print(tree1.PostOrder(tree1.Root));
            Console.WriteLine();

            // breadth first 
            Console.WriteLine("breadth");
            Print(tree1.BreadthFirst(tree1.Root));
            Console.WriteLine();

            // Max value in the Tree
            Console.WriteLine("Max value in the Tree");
            Console.WriteLine("The max value in tree is : " + tree1.findMax(tree1.Root));
            Console.WriteLine();
            
            List<object> values = new List<object>();
            // FizzBuzz
            Node root = new Node(5);
            root.child.Add(new Node(10));
            root.child.Add(new Node(15));
            root.child.Add(new Node(17));
            root.child.Add(new Node(25));
            root.child.Add(new Node(30));
            root.child[0].child.Add(new Node(35));
            root.child[0].child.Add(new Node(40));
            root.child[0].child.Add(new Node(45));
            root.child[1].child.Add(new Node(50));
            root.child[2].child.Add(new Node(52));
            root.child[2].child.Add(new Node(71));
            Console.WriteLine("FizzBuzz");
            PrintFizzBuzz(tree1.FizzBuzzTree(root));
            Console.WriteLine();

            Node n6 = new Node(100);
            Node n7 = new Node(30);
            Node n8 = new Node(110);
            Node n9 = new Node(50);
            Node n10 = new Node(45);
            BinarySearchTree binarySearchTree = new BinarySearchTree(n6);
            binarySearchTree.Add(n7);
            binarySearchTree.Add(n8);
            binarySearchTree.Add(n9);
            binarySearchTree.Add(n10);
            Console.WriteLine("Binary Search Tree");
            Print(binarySearchTree.binarySearchTree);
            Console.WriteLine("The value of position Root.Left.Right is : " + binarySearchTree.Root.Left.Right.Value); 
        }
       
        public static void Print(List<int> values) // Prints out values in list
        {
            Console.WriteLine("=+=+=+=+=+=+=");
            foreach (int value in values)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }

        public static void PrintFizzBuzz(List<object> val) 
        {
            Console.WriteLine("=+=+=+=+=+=+=");
            foreach (object value in val)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
    }
}
