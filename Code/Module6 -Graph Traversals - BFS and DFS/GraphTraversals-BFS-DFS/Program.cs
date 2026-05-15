using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GraphTraversals_BFS_DFS.Graph;

namespace GraphTraversals_BFS_DFS
{
    class Graph
    {
        public enum enGraphDirectionType { Directed, unDirected }

        private int[,] _adjacencyMatrix; // Adjacency matrix to represent the graph
        private Dictionary<string, int> _vertexDictionary; // Maps vertex names to matrix indices
        private int _numberOfVertices; // Number of vertices in the graph
        private enGraphDirectionType _GraphDirectionType = enGraphDirectionType.unDirected;

        // Constructor to initialize the graph
        public Graph(List<string> vertices, enGraphDirectionType GraphDirectionType)
        {
            _GraphDirectionType = GraphDirectionType;
            _numberOfVertices = vertices.Count; // Total number of vertices
            _adjacencyMatrix = new int[_numberOfVertices, _numberOfVertices]; // Initialize adjacency matrix
            _vertexDictionary = new Dictionary<string, int>(); // Initialize vertex dictionary

            // Map vertex names to indices
            for (int i = 0; i < vertices.Count; i++)
            {
                _vertexDictionary[vertices[i]] = i;
            }
        }

        // Add a weighted edge between two vertices
        public void AddEdge(string source, string destination, int weight)
        {
            if (_vertexDictionary.ContainsKey(source) && _vertexDictionary.ContainsKey(destination))
            {
                int sourceIndex = _vertexDictionary[source];
                int destinationIndex = _vertexDictionary[destination];
                _adjacencyMatrix[sourceIndex, destinationIndex] = weight;

                // Add the reverse edge for undirected graphs
                if (_GraphDirectionType == enGraphDirectionType.unDirected)
                {
                    _adjacencyMatrix[destinationIndex, sourceIndex] = weight;
                }
            }
            else
            {
                Console.WriteLine($"Invalid vertices: {source} or {destination}");
            }
        }

        // Display the adjacency matrix
        public void DisplayGraph(string message)
        {
            Console.WriteLine("\n" + message + "\n");
            Console.Write("  ");
            foreach (var vertex in _vertexDictionary.Keys)
            {
                Console.Write(vertex + " ");
            }
            Console.WriteLine();

            foreach (var source in _vertexDictionary)
            {
                Console.Write(source.Key + " ");
                for (int j = 0; j < _numberOfVertices; j++)
                {
                    Console.Write(_adjacencyMatrix[source.Value, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Perform Breadth-First Search (BFS)
        public void BFS(string startVertex)
        {
            if (!_vertexDictionary.ContainsKey(startVertex))
            {
                Console.WriteLine($"Invalid start vertex: {startVertex}");
                return;
            }

            //if not return then start BFS

            // Initialize visited array and queue for BFS
            bool[] visited = new bool[_numberOfVertices];
            Queue<int> queue = new Queue<int>();

            // Enqueue the starting vertex and mark it as visited
            int startIndex = _vertexDictionary[startVertex];
            visited[startIndex] = true;
            queue.Enqueue(startIndex);

            Console.WriteLine("\nBreadth-First Search:");

            //loop until the queue is empty
            while(queue.Count > 0)
            {
                //print start vertex name 
                int currentIndex = queue.Dequeue();
                Console.WriteLine(GetVertexName(currentIndex));

                // Explore neighbors of the current vertex
                for(int i=0; i< _numberOfVertices; i++)
                {
                    // Check if there is an edge and the vertex has not been visited
                    if (!visited[i] && _adjacencyMatrix[currentIndex, i] > 0)
                    {
                        //if there is an edge and not visited then enqueue the vertex and mark it as visited
                        visited[i] = true;
                        queue.Enqueue(i);
                    }
                }
            }
        }


        public void DFS(string startVertex)
        {
            if (!_vertexDictionary.ContainsKey(startVertex))
            {
                Console.WriteLine($"Invalid start vertex: {startVertex}");
                return;
            }

            //start DFS
            // Initialize visited array and stack for DFS
            bool[] visited = new bool[_numberOfVertices];
            Stack<int> stack = new Stack<int>();

            //Push the starting vertex onto the stack and mark it as visited
            int startIndex = _vertexDictionary[startVertex];
            stack.Push(startIndex);

            //loop until the stack is empty
            while(stack.Count > 0)
            {
                int currentIndex = stack.Pop();

                //skip if the vertex has already been visited
                if (visited[currentIndex])
                    continue;
                
                visited[currentIndex] = true;
                Console.WriteLine(GetVertexName(currentIndex));
                // Explore neighbors of the current vertex
                for (int i= _numberOfVertices - 1; i >= 0; i--)
                {
                    //check if there is an edge and the vertex has not been visited
                    if (!visited[i] && _adjacencyMatrix[currentIndex, i] > 0)
                    {
                        //push all the neighbors of the current vertex onto the stack
                        stack.Push(i);
                    }
                }
            }
        }

        private string GetVertexName(int index)
        {
            return _vertexDictionary.FirstOrDefault(x => x.Value == index).Key;
            //foreach (var item in _vertexDictionary)
            //{
            //    if(item.Value == index)
            //        return item.Key;
            //}
            //return null;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Define vertices
            List<string> vertices = new List<string> { "0", "1", "2", "3", "4" };

            // Create an undirected graph
            Graph graph = new Graph(vertices, enGraphDirectionType.unDirected);

            // Add edges
            graph.AddEdge("0", "1", 1);
            graph.AddEdge("0", "2", 1);

            graph.AddEdge("1", "2", 1);
            graph.AddEdge("1", "3", 1);

            graph.AddEdge("2", "3", 1);
            graph.AddEdge("2", "4", 1);



            // Display the graph
            graph.DisplayGraph("Adjacency Matrix (Undirected Graph):");

            // Perform BFS 
            Console.WriteLine("\nBreadth-First Search:");
            graph.BFS("0");

            // Perform DFS
            Console.WriteLine("\nDepth-First Search:");
            graph.DFS("0");

            Console.ReadKey();
        }
    }
}
