using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
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
}
