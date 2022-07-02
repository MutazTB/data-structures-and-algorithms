using System;
using System.Collections.Generic;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
             Graph graph2 = new Graph();

            Node n1 = new Node("Metroville");
            Node n2 = new Node("Pandora");
            Node n3 = new Node("Arendelle");
            Node n4 = new Node("New Monstropolis");
            Node n5 = new Node("Narnia");
            Node n6 = new Node("Naboo");

            graph2.AddNode("Metroville");
            graph2.AddNode("Pandora");
            graph2.AddNode("Arendelle");
            graph2.AddNode("Narnia");
            graph2.AddNode("New Monstropolis");

            graph2.AddEdge(n1, n2, 150);
            graph2.AddEdge(n2, n3, 99);
            graph2.AddEdge(n3, n5, 82);
            graph2.AddEdge(n2, n4, 105);
            graph2.AddEdge(n1, n5, 26);
            

            string[] cities = { "Metroville" , "Pandora" , "Arendelle" };
            var result = graph2.GetEdge(graph2, cities);
            
            Console.WriteLine($"${result}");
            Console.WriteLine();                      
        }

    }
}
