using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables
{
    public class Node
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public Node Next { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node() { }
        public Node(string value) 
        {
            Value = value;
        }
        public Node(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}