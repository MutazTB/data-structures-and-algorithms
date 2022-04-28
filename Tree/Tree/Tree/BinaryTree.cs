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
    }
}
