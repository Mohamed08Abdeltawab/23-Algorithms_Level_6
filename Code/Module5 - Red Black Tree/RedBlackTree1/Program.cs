using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBlackTree1
{
    public class RedBlackTree
    {
        private Node root;
        private class Node
        {
            public int Value;
            public Node Left, Right, Parent;
            public bool IsRed = true;
            public Node(int value)
            {
                this.Value = value;
            }
        }


        public void Insert(int newValue)
        {
            Node newNode = new Node(newValue);
            if(root == null)
            {
                root = newNode;
                root.IsRed = false; // Root must be black
                return;
            }

            Node current = root;
            Node parent = null;

            //get the parent and current node that null we will insert the value in
            while (current != null)
            {
                parent = current;
                if (newValue < current.Value)
                    current = current.Left;
                else
                    current = current.Right;
            }

            //set the parent of the new node
            newNode.Parent = parent;
            if(newValue < parent.Value)
                parent.Left = newNode;
            else
                parent.Right = newNode;

            FixInsert(newNode);
        }

        private void FixInsert(Node node)
        {
            Node parent = null;
            Node grandparent = null;
            while ((node != root) && (node.IsRed) && (node.Parent.IsRed))
            {
                //assign the parent and grandparent
                parent = node.Parent;
                grandparent = parent.Parent;

                //if parent is left child of grandparent
                if(parent == grandparent.Left)
                {
                    //make uncle in the right node
                    Node uncle = grandparent.Right;

                    //case 1: uncle is red, only recoloring is needed
                    if(uncle != null && uncle.IsRed)
                    {
                        //make grandparent red and parent and uncle black
                        grandparent.IsRed = true;
                        parent.IsRed = false;
                        uncle.IsRed = false;

                        //after recoloring, move the current node up to the grandparent
                        node = grandparent;
                    }
                    else//if uncle is black, we perform case 2 or case 3 that check the shape of the current node if Triangle or Line
                    {
                        //case 2: if node is right child of its parent(triangle shape), we perform left rotation on parent
                        if(node == parent.Right)
                        {
                            LeftRotate(parent);
                            node = parent;
                            parent = node.Parent;
                        }

                        //case 3: if node is left child of its parent(line shape),
                        //we perform right rotation on grandparent to balance the tree and recolor the nodes
                        RightRotate(grandparent);
                        //swap the colors of parent and grandparent
                        (parent.IsRed, grandparent.IsRed) = (grandparent.IsRed, parent.IsRed);
                        node = parent;
                    }
                }
                else
                {
                    //make uncle in the left node
                    Node uncle = grandparent.Left;

                    //case 1: uncle is red, only recoloring is needed
                    if(uncle != null && uncle.IsRed)
                    {
                        //make grandparent red and parent and uncle black
                        grandparent.IsRed = true;
                        parent.IsRed = false;
                        uncle.IsRed = false;

                        //after recoloring, move the current node up to the grandparent
                        node = grandparent;
                    }
                    else//if uncle is black, we perform case 2 or case 3 that check the shape of the current node if Triangle or Line
                    {
                        //case 2: if node is left child of its parent(triangle shape), we perform right rotation on parent
                        if(node == parent.Left)
                        {
                            RightRotate(parent);
                            node = parent;
                            parent = node.Parent;
                        }

                        //case 3: if node is right child of its parent(line shape),
                        //we perform left rotation on grandparent to balance the tree and recolor the nodes
                        LeftRotate(grandparent);
                        //swap the colors of parent and grandparent
                        (parent.IsRed, grandparent.IsRed) = (grandparent.IsRed, parent.IsRed);
                        node = parent;
                    }
                }
            }
            root.IsRed = false; // Ensure the root is always black
        }


        // Rotate left pivots around the given node making the right child the parent of the pivoted node
        private void LeftRotate(Node node)
        {
            Node right = node.Right; // Right child becomes the new root of the subtree
            node.Right = right.Left; // Move the left subtree of right to the right subtree of node
            if (node.Right != null)
                node.Right.Parent = node; // Set parent of the new right child


            right.Parent = node.Parent; // Connect new root with the grandparent


            if (node.Parent == null)
                root = right; // The right child becomes new root of the tree
            else if (node == node.Parent.Left)
                node.Parent.Left = right; // Set right child to left child of parent
            else
                node.Parent.Right = right; // Set right child to right child of parent


            right.Left = node; // Original node becomes the left child of its right child
            node.Parent = right; // Update parent of the original node
        }

        // Rotate right pivots around the given node making the left child the parent of the pivoted node
        private void RightRotate(Node node)
        {
            Node left = node.Left; // Left child becomes the new root of the subtree
            node.Left = left.Right; // Move the right subtree of left to the left subtree of node
            if (node.Left != null)
                node.Left.Parent = node; // Set parent of the new left child


            left.Parent = node.Parent; // Connect new root with the grandparent


            if (node.Parent == null)
                root = left; // The left child becomes new root of the tree
            else if (node == node.Parent.Right)
                node.Parent.Right = left; // Set left child to right child of parent
            else
                node.Parent.Left = left; // Set left child to left child of parent


            left.Right = node; // Original node becomes the right child of its left child
            node.Parent = left; // Update parent of the original node
        }



        // Public method to print the tree
        public void PrintTree()
        {
            PrintHelper(root, "", true);
        }


        // Helper method to print the tree
        private void PrintHelper(Node node, string indent, bool last)
        {
            if (node != null)
            {
                Console.Write(indent);
                if (last)
                {
                    Console.Write("R----");
                    indent += "   ";
                }
                else
                {
                    Console.Write("L----");
                    indent += "|  ";
                }
                var color = node.IsRed ? "RED" : "BLK";
                Console.WriteLine(node.Value + "(" + color + ")");
                PrintHelper(node.Left, indent, false);
                PrintHelper(node.Right, indent, true);
            }
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RedBlackTree rbTree = new RedBlackTree();


            // Test values to be inserted into the tree
            int[] values = { 10, 20, 30, 15, 25, 35, 5, 19 };
            foreach (var value in values)
            {
                Console.WriteLine($"Inserting {value} to the tree\n");
                rbTree.Insert(value);
                rbTree.PrintTree();
                Console.WriteLine("\n--------------------------------\n");
            }
            Console.ReadKey();
        }
    }
}
