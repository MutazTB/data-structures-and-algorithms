using Graphs;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestGraph
{
    public class UnitTest1
    {
        [Fact]
        public void DepthFirstTest()
        {
            Graph graph = new Graph();

            Node A = new Node("A");
            Node B = new Node("B");
            Node C = new Node("C");
            Node D = new Node("D");
            Node E = new Node("E");
            Node F = new Node("F");
            Node H = new Node("H");

            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");
            graph.AddNode("H");

            graph.AddEdge(A, B, 150);
            graph.AddEdge(A, D, 99);
            graph.AddEdge(B, C, 82);
            graph.AddEdge(B, D, 105);
            graph.AddEdge(D, F, 26);
            graph.AddEdge(D, H, 10);
            graph.AddEdge(D, E, 13);
            graph.AddEdge(F, H, 15);

            List<Node> depthFirst = graph.DepthFirst(graph);
            List<Object> result = new List<object>();
            foreach (var item in depthFirst)
            {
                result.Add(item.Value);
            }
            List<Object> expected = new List<Object>{ "A","B","C", "D", "F", "H", "E" };
            Assert.Equal(expected , result);
        }

        [Fact]
        public void DepthFirstEmptyTest()
        {
            Graph graph = new Graph();

            List<Node> result = graph.DepthFirst(graph);

            Assert.Null(result);
        }

    }
}
