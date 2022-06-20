# Graphs
A graph is a non-linear data structure that can be looked at as a a collection of points made up of vertices (or nodes) potentially being connected by line segments named edges.

## Challenge
Implement your own Graph. The graph should be represented as an adjacency list. that includes the following:

- AddEdge()
    - Adds a new vertice to the graphs
Include the ability to have a “weight”
Bring in both the parent node, and the new node to be added
- GetNodes()
    - returns all of the nodes in the graph as a collection
- GetNeighbors()
    - returns a collection of nodes connected to the given node
Bring in a given node
Include the weight from the given node.
- Size()
    - returns the total number of nodes in the graph

## Approach & Efficiency

#### AddVertex Method
**Time** O(1)<br>
**Space** O(1)
#### AddEdge Method
**Time** O(1)<br>
**Space** O(1)
#### GetVerticies Method
**Time** O(n)<br>
**Space** O(n)
#### GetNeighbors Method
**Time** O(1)<br>
**Space** O(n)
#### GetSize Method
**Time** O(1)<br>
**Space** O(1)

## API
- AddEdge()
- GetNodes()
- GetNeighbors()
- Size()