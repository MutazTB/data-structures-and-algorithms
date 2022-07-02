using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Node
    {
        /// <summary>
        /// The value of the node
        /// </summary>
        public Object Value { get; set; }
        //public string value { get; set; }
        
        public List<Node> Children { get; set; }
        public List<Edge> Edge { get; set; } = new List<Edge>();

        public bool Visited { get; set; }

        public Node(Object value)
        {
            Value = value;
            Visited = false;
            Children = new List<Node>();
        }
        //public Node(string Value)
        //{
        //    value = Value;
        //    Visited = false;
        //    Children = new List<Node>();
        //}
    }
}
