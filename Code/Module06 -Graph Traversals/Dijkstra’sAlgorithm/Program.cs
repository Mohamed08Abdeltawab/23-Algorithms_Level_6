using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_sAlgorithm
{
    class Graph
    {
        public enum enGraphDirectionType { Directed, unDirected }

        private int[,] _adjacencyMatrix;
        private Dictionary<string, int> _vertexDictionary;
        private int _numberOfVertices;
        private enGraphDirectionType _GraphDirectionType;

        // Constructor
        public Graph(List<string> vertices, enGraphDirectionType GraphDirectionType)
        {
            _GraphDirectionType = GraphDirectionType;
            _numberOfVertices = vertices.Count;
            _adjacencyMatrix = new int[_numberOfVertices, _numberOfVertices];
            _vertexDictionary = new Dictionary<string, int>();

            for (int i = 0; i < vertices.Count; i++)
            {
                _vertexDictionary[vertices[i]] = i;
            }
        }

        // Add an edge to the graph
        public void AddEdge(string source, string destination, int weight)
        {
            if (_vertexDictionary.ContainsKey(source) && _vertexDictionary.ContainsKey(destination))
            {
                int sourceIndex = _vertexDictionary[source];
                int destinationIndex = _vertexDictionary[destination];
                _adjacencyMatrix[sourceIndex, destinationIndex] = weight;

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

        // Display the graph as an adjacency matrix
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

        // Dijkstra's Algorithm: Finds the shortest paths from a source vertex
        
        // Helper to get the vertex name by its index
        private string GetVertexName(int index)
        {
            //foreach (var pair in _vertexDictionary)
            //{
            //    if (pair.Value == index)
            //        return pair.Key;
            //}
            //return null;
            return _vertexDictionary.FirstOrDefault(x => x.Value == index).Key;
        }

        private string GetPath(string[] predecessor, int currentIndex)
        {
            // Base case:
            // if the current vertex has no predecessor,
            // then it is the starting vertex in the path
            if (predecessor[currentIndex] == null)
                return GetVertexName(currentIndex); // return the start vertex name

            // Recursive case:
            // get the path of the predecessor first,
            // then append the current vertex name to the path

            // Example:
            // if current vertex is C,
            // predecessor[C] = B
            // predecessor[B] = A
            // then the final path becomes:
            // A -> B -> C

            return GetPath(predecessor,
                           _vertexDictionary[predecessor[currentIndex]])
                   + " -> "
                   + GetVertexName(currentIndex);
        }

        private int GetMinDistanceVertex(int[] distances, bool[] visited)
        {
            // Start with the maximum possible value
            // so any smaller distance can replace it
            int minDistance = int.MaxValue;

            // Start with an invalid index
            // in case no valid vertex is found
            int minIndex = -1;

            // Loop through all vertices
            for (int i = 0; i < _numberOfVertices; i++)
            {
                // Check if the vertex:
                // 1- has not been visited yet
                // 2- has a smaller distance than the current minimum
                if (!visited[i] && distances[i] < minDistance)
                {
                    // Update the minimum distance
                    minDistance = distances[i];

                    // Store the index of the closest vertex
                    minIndex = i;
                }
            }

            // Return the index of the vertex
            // with the smallest unvisited distance
            return minIndex;
        }

        
        public void Dijkstra(string startVertex)
        {
            //check if the start vertex exists in the graph
            if (!_vertexDictionary.ContainsKey(startVertex))
            {
                Console.WriteLine($"Start vertex '{startVertex}' does not exist in the graph.");
                return;
            }

            // Initialize distances and visited arrays and predecessor array
            int[] distances = new int[_numberOfVertices];
            bool[] visited = new bool[_numberOfVertices];
            string[] predecessor = new string[_numberOfVertices];

            //set all distances to infinity (or a very large number)
            for(int i = 0; i< _numberOfVertices; i++)
            {
                distances[i] = int.MaxValue;
                visited[i] = false;
                predecessor[i] = null; // no predecessor at the start
            }

            // Set the distance of the start vertex to 0
            int startIndex = _vertexDictionary[startVertex];
            distances[startIndex] = 0;

            //main loop of Dijkstra's algorithm
            for(int count=0; count<_vertexDictionary.Count -1;count++)
            {
                //step 3: select the unvisited vertex with the smallest distance
                int minVertex = GetMinDistanceVertex(distances, visited);
                //mark the selected vertex as visited
                visited[minVertex] = true;

                //step 4: update the distances of the neighboring vertices
                for (int v = 0; v < _numberOfVertices; v++)
                {
                    //update distance if
                    //1- there is an edge
                    //2- the vertex is unvisited
                    //3- the new distance is smaller than the current distance
                    if (!visited[v]  //must be unvisited
                        && _adjacencyMatrix[minVertex, v] > 0 //must be has whight higher than 0 and not visited
                        && distances[minVertex] != int.MaxValue //must be reachable
                        && distances[minVertex] + _adjacencyMatrix[minVertex, v] < distances[v]) //the new distance is smaller than the current distance
                    {
                        //update the distance to the neighboring vertex
                        distances[v] = distances[minVertex] + _adjacencyMatrix[minVertex, v];
                        
                        //update the predecessor of the neighboring vertex
                        predecessor[v] = GetVertexName(minVertex);
                    }
                }
            }

            // Display the shortest paths from the start vertex to all other vertices
            Console.WriteLine("\nShortest paths from vertex '{0}':", startVertex);
            for(int i = 0;i< _numberOfVertices; i++)
            {
                Console.WriteLine($"{startVertex} -> {GetVertexName(i)}: Distance = {distances[i]}, Path = {GetPath(predecessor,i)}");
            }

        }




        public void Dijkstra(string startVertex, string endVertex)
        {
            if(!_vertexDictionary.ContainsKey(startVertex) || !_vertexDictionary.ContainsKey(endVertex))
            {
                Console.WriteLine($"Start vertex '{startVertex}' or end vertex '{endVertex}' does not exist in the graph.");
                return;
            }

            // Initialize distances and visited arrays and predecessor array
            int startIndex = _vertexDictionary[startVertex];
            int[] distances = new int[_numberOfVertices];
            bool[] visited = new bool[_numberOfVertices];
            string[] predecessor = new string[_numberOfVertices];

            //set all distances to infinity (or a very large number)
            for (int i = 0; i < _numberOfVertices; i++)
            {
                distances[i] = int.MaxValue;
                visited[i] = false;
                predecessor[i] = null; // no predecessor at the start
            }
            distances[startIndex] = 0;

            var priorityQueue = new SortedSet<(int Distance, int VertexIndex)>(Comparer<(int Distance, int VertexIndex)>.Create((a, b) =>
            a.Distance == b.Distance ? a.VertexIndex.CompareTo(b.VertexIndex) : a.Distance.CompareTo(b.Distance)));

            priorityQueue.Add((0, startIndex));

            // Main loop of Dijkstra's algorithm
            while(priorityQueue.Count > 0)
            {
                var (currentDistance, currentIndex) = priorityQueue.Min;
                priorityQueue.Remove(priorityQueue.Min);

                if (visited[currentIndex]) continue;
                visited[currentIndex] = true;

                //update the distance for all neighbors of the current vertex
                for(int neighbor = 0; neighbor < _numberOfVertices; neighbor++)
                {
                    if (_adjacencyMatrix[currentIndex, neighbor] > 0 && !visited[neighbor])//if neightbor is an dege and not visited
                    {
                        int newDistance = distances[currentIndex] + _adjacencyMatrix[currentIndex, neighbor];

                        //if the new distance is shorter, update it 
                        if(newDistance < distances[neighbor])
                        {
                            //remove the old distance from the priority queue
                            priorityQueue.Remove((distances[neighbor], neighbor));
                            //update the distance and predecessor
                            distances[neighbor] = newDistance;
                            predecessor[neighbor] = GetVertexName(currentIndex);
                            //add the new distance to the priority queue
                            priorityQueue.Add((newDistance, neighbor));
                        }
                    }
                }
            }
            int endIndex = _vertexDictionary[endVertex];
            if (distances[endIndex] == int.MaxValue)
            {
                Console.WriteLine($"No path exists from '{startVertex}' to '{endVertex}'.");
            }
            else
            {
                Console.WriteLine($"\nShortest path from '{startVertex}' to '{endVertex}': Distance = {distances[endIndex]}, Path = {GetPath(predecessor, endIndex)}");
            }
        }


        // Main method to test the program
        public static void Main(string[] args)
        {
            // Define vertices
            List<string> vertices = new List<string> { "A", "B", "C", "D", "E" };

            // Create a directed graph
            Graph graph = new Graph(vertices, enGraphDirectionType.Directed);

            // Add edges with weights
            graph.AddEdge("A", "B", 4);
            graph.AddEdge("A", "C", 1);
            graph.AddEdge("C", "B", 2);
            graph.AddEdge("C", "D", 4);
            graph.AddEdge("B", "E", 4);
            graph.AddEdge("D", "E", 1);

            // Display the graph
            graph.DisplayGraph("Adjacency Matrix:");

            // Run Dijkstra's Algorithm from vertex "A"
            graph.Dijkstra("A");

            Console.WriteLine("\nFinding the shortest path from A to E:");
            graph.Dijkstra("A", "E");

            Console.ReadKey();
        }
    }
}
