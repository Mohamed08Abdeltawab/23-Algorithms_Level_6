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
        #endregion
    }


}
