using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Node
    {
        public int Value { get; set; }
        public string value2 { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public bool isLeaf()
        {
            return Left == null ? Right == null : false;
        }
        public List<Node> child;

        public Node(int value)
        {
            Value = value;
            child = new List<Node>();
        }
        public Node(string value)
        {
            value2 = value;
            child = new List<Node>();
        }
    }
}
