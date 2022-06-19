using Hashtables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public List<string> Values = new List<string>();

        public BinaryTree(Node root)
        {
            Root = root;
        }
        public BinaryTree()
        {

        }

        public List<string> PreOrder(Node node) // Root   Left   Right
        {
            string value = node.Value;
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

        public List<string> InOrder(Node node)
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

        public List<string> PostOrder(Node node)
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

    }
}
