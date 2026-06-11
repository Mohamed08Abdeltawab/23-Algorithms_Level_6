using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_Problems_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 8: File Permission System
            Console.WriteLine("====== Problem 8 ======");

            // Build the file structure
            var root = new PermissionNode("Root", "rwx"); // Root has "rwx" permissions
            var folder1 = new PermissionNode("Folder1", "rw-"); // Folder1 has "rw-" permissions
            var folder2 = new PermissionNode("Folder2", ""); // Folder2 inherits permissions from its parent
            var file1 = new PermissionNode("File1", ""); // File1 inherits permissions from its parent
            var file2 = new PermissionNode("File2", "r--"); // File2 has "r--" permissions


            // Add children to the structure
            root.Children.Add(folder1);
            root.Children.Add(folder2);
            folder1.Children.Add(file1);
            folder2.Children.Add(file2);


            // Print the file permissions for all nodes
            Console.WriteLine("File Permissions:");
            root.PrintPermissions();


            #endregion
        }
    }

    //classes for problem 8
    #region from Problem 8: File Permission System
    class PermissionNode
    {
        public string Name { get; set; }
        public string Permission { get; set; }
        public List<PermissionNode> Children { get; set; } = new List<PermissionNode>();

        public PermissionNode(string name, string permission)
        {
            Name = name;
            Permission = permission;
        }

        public void PrintPermissions(string inheritedPermission = "", string indent = "")
        {
            string effectivePermission = Permission == "" ? inheritedPermission : Permission;
            Console.WriteLine($"{indent}{Name}: {effectivePermission}");
            foreach (var child in Children)
            {
                child.PrintPermissions(effectivePermission, indent + "  ");
            }
        }


    }


    #endregion
}
