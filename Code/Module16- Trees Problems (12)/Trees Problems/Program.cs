using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Trees_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1: File System Organization
            Console.WriteLine("====== Problem 1 ======");

            FileNode root1 = new FileNode("Root", FileNode.NodeType.Directory);

            var documents1 = new FileNode("Documents", FileNode.NodeType.Directory);
            var photos1 = new FileNode("Photos", FileNode.NodeType.Directory);

            documents1.Children.Add(new FileNode("Resume.docx", FileNode.NodeType.File));
            documents1.Children.Add(new FileNode("Project.pdf", FileNode.NodeType.File));
            photos1.Children.Add(new FileNode("Vacation.jpg", FileNode.NodeType.File));
            photos1.Children.Add(new FileNode("Family.png", FileNode.NodeType.File));
            photos1.Children.Add(new FileNode("Friends.gif", FileNode.NodeType.File));

            root1.Children.Add(documents1);
            root1.Children.Add(photos1);

            root1.Print();

            #endregion


            #region Problem2: Hierarchical Employee Management
            Console.WriteLine("\n====== Problem 2 ======");

            HierarchyNode CEO = new HierarchyNode("Alice", "CEO");

            var Bob = new HierarchyNode("Bob", "VP of Marketing");
            var Lara = new HierarchyNode("Lara", "VP of Technology");

            Bob.Children.Add(new HierarchyNode("Charlie", "Marketing Manager"));

            Lara.Children.Add(new HierarchyNode("Dave", "Tech Lead"));
            Lara.Children.Add(new HierarchyNode("Eve", "Software Engineer"));

            CEO.Children.Add(Bob);
            CEO.Children.Add(Lara);

            CEO.Print();


            #endregion

            #region Problem3: Directory Size Calculation
            Console.WriteLine("\n====== Problem 3 ======");

            var root3 = new DirectorySizeNode("root", 0);
            var documents3 = new DirectorySizeNode("Documents", 0);
            var photos3 = new DirectorySizeNode("Photos", 0);


            documents3.Children.Add(new DirectorySizeNode("Resume.docx", 50));
            documents3.Children.Add(new DirectorySizeNode("Project.pdf", 100));

            photos3.Children.Add(new DirectorySizeNode("Vacation.jpg", 200));


            root3.Children.Add(documents3);
            root3.Children.Add(photos3);

            // Print directory structure
            Console.WriteLine("Directory Structure:");
            root3.Print();


            // Calculate and display total size
            Console.WriteLine($"\nTotal size of the directory: {root3.CalculateTotalSize()} bytes");
            #endregion


            #region Problem4: Priority Scheduling (Min-Heap Implementation)
            Console.WriteLine("\n====== Problem 4 ======");

            var scheduler = new Min_Heap();

            // Add tasks with priorities
            scheduler.Insert(new Task4("Task A", 3));
            scheduler.Insert(new Task4("Task B", 1));
            scheduler.Insert(new Task4("Task C", 2));
            Console.WriteLine("Tasks entered in this order: Task A, Task B, Task C.\n");

            // Process tasks in priority order
            Console.WriteLine("Executing tasks in priority order:");
            while (!scheduler.isEmpty())
            {
                Console.WriteLine(scheduler.ExtractMin());
            }

            #endregion


            #region Problem5: Decision-Making Process
            Console.WriteLine("\n====== Problem 5 ======");

            var root = new DecisionNode5("Is it raining?");
            root.Yes = new DecisionNode5("Do you have an umbrella?");
            root.No = new DecisionNode5("Is it sunny?");
            root.Yes.Yes = new DecisionNode5("Go outside.");
            root.Yes.No = new DecisionNode5("Stay inside.");
            root.No.Yes = new DecisionNode5("Go outside.");
            root.No.No = new DecisionNode5("Stay inside.");

            var currentNode = root;


            // Traverse the tree based on user input
            while (currentNode.Yes != null && currentNode.No != null)
            {
                Console.WriteLine(currentNode.Question); // Ask the current question
                string answer = Console.ReadLine().Trim().ToLower(); // Get user input ("yes" or "no")


                // Navigate to the next node based on the answer
                if (answer == "yes")
                    currentNode = currentNode.Yes;
                else if (answer == "no")
                    currentNode = currentNode.No;
                else
                    Console.WriteLine("Please answer 'yes' or 'no'.");
            }


            // Display the recommendation (leaf node)
            Console.WriteLine(currentNode.Question);

            #endregion
        }
    }

    //Classes for Problem1
    #region from Problem1: File System Organization
    class FileNode
    {
        public string Name { get; set; }
        public bool IsDirectory { get; set; }
        public List<FileNode> Children { get; set; } = new List<FileNode>();

        public enum NodeType
        {
            File,
            Directory
        }

        public FileNode(string name, NodeType isDirectory)
        {
            Name = name;
            IsDirectory = (isDirectory == NodeType.Directory) ? true : false;
        }

        public void Print(string indent = "")
        {
            Console.WriteLine(indent + (IsDirectory ? "Directory: " : "File: ") + Name);
            foreach(var child in Children)
            {
                child.Print(indent + "  ");
            }
        }

    }
    #endregion


    //Classes for Problem2
    #region from Problem2: Hierarchical Employee Management
    class HierarchyNode
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public List<HierarchyNode> Children { get; set; } = new List<HierarchyNode>();

        
        public HierarchyNode(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public void Print(string indent = "")
        {
            Console.WriteLine(indent + Position + ": " + Name);
            foreach (var child in Children)
            {
                child.Print(indent + "  ");
            }
        }

    }
    #endregion


    //Classes for Problem3
    #region from Problem3: Directory Size Calculation
    class DirectorySizeNode
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public List<DirectorySizeNode> Children { get; set; } = new List<DirectorySizeNode>();


        public DirectorySizeNode(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public int CalculateTotalSize()
        {
            int totalSize = Size; // Start with the current node's size
            foreach (var child in Children)
            {
                totalSize += child.CalculateTotalSize(); // Add sizes of all child nodes
            }
            return totalSize;
        }

        public void Print(string indent = "")
        {
            Console.WriteLine($"{indent}{Name} (Size: {Size})");
            foreach (var child in Children)
            {
                child.Print(indent + "  ");
            }
        }

    }
    #endregion


    //Classes for Problem4
    #region from Problem4: Priority Scheduling (Min-Heap Implementation)
    class Task4
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public Task4(string name, int priority)
        {
            Name = name;
            Priority = priority;
        }

        public override string ToString()
        {
            return $"{Name} (Priority: {Priority})";
        }
    }

    class Min_Heap
    {
        private List<Task4> heap = new List<Task4>();
        
        public void Insert(Task4 task)
        {
            heap.Add(task);
            heapifyUp(heap.Count - 1);//reArrange heap after inset
        }

        public Task4 ExtractMin()
        {
            if (heap.Count == 0) return null;

            var minTask = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            heapifyDown(0);//reArrange heap after delete
            return minTask;
        }


        public void heapifyUp(int index)
        {
            int parentIndex = (index - 1) / 2;
            //if index greater than 0 and has a less pirority than his father then swap
            if(index > 0 && heap[index].Priority < heap[parentIndex].Priority)
            {
                (heap[index], heap[parentIndex]) = (heap[parentIndex], heap[index]);
                index = parentIndex;
            }
        }
        public void heapifyDown(int index)
        {
            int smallest = index;
            int leftChild = (2 * index) + 1;
            int rightChild = (2* index) + 2;

            if (leftChild < heap.Count && heap[leftChild].Priority < heap[smallest].Priority)
                smallest = leftChild;

            if(rightChild < heap.Count && heap[rightChild].Priority < heap[smallest].Priority)
                smallest = rightChild;

            if(smallest != index)//if there a change recursion if not then the index is the smallest one and break
            {
                (heap[index], heap[smallest]) = (heap[smallest], heap[index]);
                heapifyDown(smallest);
            }
        }

        public bool isEmpty()
        {
            return (heap.Count == 0);
        }
    }



    #endregion


    //Classes for Problem5
    #region from Problem5: Decision-Making Process
    class DecisionNode5
    {
        public string Question { get; set; }
        public DecisionNode5 Yes { get; set; }
        public DecisionNode5 No { get; set; }

        public DecisionNode5(string question)
        {
            Question = question;
        }
    }

    
    #endregion
}
