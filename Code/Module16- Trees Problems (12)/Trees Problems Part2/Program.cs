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


            #region Problem 9: Category Hierarchy
            Console.WriteLine("\n====== Problem 9 ======");

            // Build the category hierarchy
            var root9 = new CategoryNode("Electronics"); // Root category
            var mobiles = new CategoryNode("Mobiles"); // Subcategory for mobiles
            var laptops = new CategoryNode("Laptops"); // Subcategory for laptops
            var samsung = new CategoryNode("Samsung"); // Sub-subcategory for Samsung
            var apple = new CategoryNode("Apple"); // Sub-subcategory for Apple

            // Add subcategories
            mobiles.SubCategories.Add(samsung);
            mobiles.SubCategories.Add(apple);
            root9.SubCategories.Add(mobiles);
            root9.SubCategories.Add(laptops);

            // Print the category hierarchy
            Console.WriteLine("Category Hierarchy:");
            root9.Print(); // Start from the root
            #endregion


            #region Problem 10: Maximum Depth of a Binary Tree
            Console.WriteLine("\n====== Problem 10 ======");

            var tree10 = new BinaryTree();


            // Build a sample tree
            var root10 = new TreeNode10(1);
            root10.Left = new TreeNode10(2);
            root10.Right = new TreeNode10(3);
            root10.Left.Left = new TreeNode10(4);
            root10.Left.Right = new TreeNode10(5);

            // Calculate and print the maximum depth
            Console.WriteLine($"Maximum Depth: {tree10.MaxDepth(root10)}");

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


    //classes for problem 9
    #region from Problem 9: Category Hierarchy
    class CategoryNode
    {
        public string Name { get; set; } // Name of the category
        public List<CategoryNode> SubCategories { get; set; } = new List<CategoryNode>(); // List of subcategories

        public CategoryNode(string name)
        {
            Name = name; // Initialize the category with a name
        }

        // Recursive method to print the category hierarchy
        public void Print(string indent = "")
        {
            Console.WriteLine(indent + Name); // Print the current category
            foreach (var subCategory in SubCategories) // Loop through subcategories
            {
                subCategory.Print(indent + "  "); // Recursively print subcategories with indentation
            }
        }

    }

    #endregion


    //classes for problem 10
    #region from Problem 10: Maximum Depth of a Binary Tree
    class TreeNode10
    {
        public int Value { get; set; }
        public TreeNode10 Left { get; set; }
        public TreeNode10 Right { get; set; }


        public TreeNode10(int value)
        {
            Value = value;
        }
    }

    class BinaryTree
    {
        public int MaxDepth(TreeNode10 root)
        {
            if(root == null) return 0;

            int leftDepth = MaxDepth(root.Left);
            int rightDepth = MaxDepth(root.Right);

            return Math.Max(leftDepth, rightDepth) + 1;//one for root and starting from 0 for null nodes
        }
    }



    #endregion
}
