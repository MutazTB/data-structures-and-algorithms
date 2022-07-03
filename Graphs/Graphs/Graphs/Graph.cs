using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Graph
    {        
        public List<Node> Nodes { get; set; } = new List<Node>();

        public void AddEdge(Node firstNode, Node secondNode, int weight)
        {
            if (firstNode == secondNode)
            {
                Node point = Nodes.Find(v => v.Value == firstNode.Value);
                Edge edge = new Edge(point, weight);
                Nodes.Find(v => v.Value == firstNode.Value).Edge.Add(edge);
                return;
            }

            Node firstPoint = Nodes.Find(v => v.Value == firstNode.Value);
            Node secondPoint = Nodes.Find(v => v.Value == secondNode.Value);

            Edge firstEdge = new Edge(secondPoint, weight);
            firstPoint.Edge.Add(firstEdge);

            Edge secondEdge = new Edge(firstPoint, weight);
            secondPoint.Edge.Add(secondEdge);
        }

        public Object AddNode(Object value)  // Adds a node to the graph.
        {
            Node node = new Node(value);
            Nodes.Add(node);
            return node;
        }
        public List<Node> GetNodes()
        {
            return Nodes;
        }

        public int Size()
        {
            return Nodes.Count;
        }

        public List<Edge> GetNeighbors(Node node) // Returns a count of all the nodes in a graph
        {
            return Nodes.Find(v => v.Value == node.Value).Edge;
        }


        public List<Node> BreadthFirst(Node root)
        {
            List<Node> order = new List<Node>();
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);
            root.Visited = true;  // This makes sure that the root isn't returned twice

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                order.Add(front);

                foreach (Node child in front.Children)
                {
                    if (!child.Visited)
                    {
                        child.Visited = true;
                        breadth.Enqueue(child);
                    }
                }
            }
            return order;
        }

        public int GetEdge(Graph graph, string[] cities)
        {
            int cost = 0;
            if (cities.Length <= 1)
            {
                return 0;
            }
            for (int i = 0; i < cities.Length - 1; i++)
            {
                List<Edge> nodeEdges = graph.GetNeighbors(new Node(cities[i]));
                if (!nodeEdges.Exists(n => n.Neighbor.Value.ToString() == cities[i + 1]))
                {
                    return 0;
                }
                else
                {
                    cost += nodeEdges.Find(n => n.Neighbor.Value.ToString() == cities[i + 1]).Weight;
                }
            }
            return cost;
        }

        public List<Node> DepthFirst(Graph graph)
        {
            if (graph.Nodes.Count == 0)
            {
                return null;
            }
            List<Node> result = new List<Node>();
            Node root = graph.Nodes[0];

            result = DepthFirstHelper(graph, result, root);
            return result;
        }
        public List<Node> DepthFirstHelper(Graph graph, List<Node> list1, Node root) 
        {
            root.Visited = true;
            list1.Add(root);
            foreach (Edge edge in root.Edge)
            {
                if (!edge.Neighbor.Visited)
                {
                    DepthFirstHelper(graph, list1, edge.Neighbor);
                }
            }
            return list1;
        }
    }
}
