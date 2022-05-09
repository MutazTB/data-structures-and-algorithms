using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public List<int> Values = new List<int>();

        public BinaryTree(Node root)
        {
            Root = root;
        }
        public BinaryTree()
        {

        }
        
        public List<int> PreOrder(Node node) // Root   Left   Right
        {
            int value = node.Value;
            Values.Add(value);

            if (node.Left != null)
            {
                PreOrder(node.Left);
            }
            if (node.Right != null)
            {
                PreOrder(node.Right);
            }

            return Values;
        }

        public List<int> InOrder(Node node)
        {
            if (node.Left != null)
            {
                InOrder(node.Left);
            }

            Values.Add(node.Value);

            if (node.Right != null)
            {
                InOrder(node.Right);
            }

            return Values;
        }

        public List<int> PostOrder(Node node)
        {
            if (node.Left != null)
            {
                PostOrder(node.Left);
            }

            if (node.Right != null)
            {
                PostOrder(node.Right);
            }

            Values.Add(node.Value);

            return Values;
        }

        public int findMax(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            int root = node.Value;
            int left = findMax(node.Left);
            int right = findMax(node.Right);
            
                if (left > root)
                {
                    root = left;                    
                }
                if (right > root)
                {
                    root = right;                   
                }
                
            return root;
        }

        public List<int> BreadthFirst(Node node)
        {
            Queue<Node> breadth = new Queue<Node>();
            List<int> values = new List<int>();

            breadth.Enqueue(node);

            while (breadth.TryPeek(out node))
            {
                Node front = breadth.Dequeue();
                values.Add(front.Value);

                if (front.Left != null)
                {
                    breadth.Enqueue(front.Left);
                }

                if (front.Right != null)
                {
                    breadth.Enqueue(front.Right);
                }
            }
            return values;
        }

        public List<object> FizzBuzzTree(Node node)
        {
            List<object> result = new List<object>();
            if (node == null)
            {
                Console.WriteLine("Nothing here");
            }
            Queue<Node> FizzBuzz = new Queue<Node>();
            FizzBuzz.Enqueue(node);
            while (FizzBuzz.Count > 0)
            {
                for (int i = 0; i < FizzBuzz.Count; i++)
                {
                    if (FizzBuzz.First().Value % 5 == 0 && FizzBuzz.First().Value % 3 == 0)
                    {
                        result.Add("FizzBuzz");
                    }
                    else if (FizzBuzz.First().Value % 5 == 0)
                    {
                        result.Add("Buzz");
                    }
                    else if (FizzBuzz.First().Value % 3 == 0)
                    {
                        result.Add("Fizz");
                    }
                    else
                    {
                        result.Add(FizzBuzz.First().Value);
                    }
                    Node node2 = FizzBuzz.Dequeue();
                    foreach (var item in node2.child)
                    {
                        FizzBuzz.Enqueue(item);
                    }
                }
            }
            return result;
        }

    }
}
