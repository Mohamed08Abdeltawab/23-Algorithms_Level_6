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
        private Node root;//in first time is null
        public class Node
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
            while (current != null)//if that was flase that means we got the destination of new node and assigned parent to his current node we know
            {
                parent = current;
                //new value that is the value of new node we just inserted has left and right null
                //we comparing with current.value to get to the position that we insdrted this node in
                if (newValue < current.Value)
                    current = current.Left;
                else
                    current = current.Right;
            }

            //set the parent of the new node
            newNode.Parent = parent;
            //if new value was less than parent value then the new node will be in parent.left node if node will be in parent.right
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
            //if its not has the first case that root equal node
            //and must node is red and parent is red
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
                    if(uncle != null && uncle.IsRed)//if uncle has value and his color is red
                    {
                        //make grandparent red and parent and uncle black
                        grandparent.IsRed = true;
                        parent.IsRed = false;
                        uncle.IsRed = false;

                        //after recoloring, move the current node up to the grandparent
                        //because we fixt this node contain 4 nodes -> grandparent , parent , nucle , new node
                        node = grandparent;
                        //after that will check again in while loop if need fixing will do it
                    }
                    else//if uncle is black or null, we perform case 2 or case 3 that check the shape of the current node if Triangle or Line
                    {
                        //case 2: if node is right child of its parent(triangle shape), we perform left rotation on parent
                        //parent in left and his child(new node) in right that make a triangle shape
                        if(node == parent.Right)
                        {
                            LeftRotate(parent);//make left rotate on parent make parent and his child in left side
                            node = parent;//after rotation move node up will check in his parent 
                            parent = node.Parent;//and make his parent equal his grandparent
                        }

                        //if access to the if statement that mean we already make a rotation is line shape
                        //and if not access in if statement than mean is already line shape we don't need to change it
                        //but if access in if statement that make it move up 
                        //if not that will be as it

                        //case 3: if node is left child of its parent(line shape),
                        //we perform right rotation on grandparent to balance the tree and recolor the nodes
                        RightRotate(grandparent);//because the shape is parent in left and new node in left then we balance with right rotation in grandparent
                        //swap the colors of parent and grandparent
                        (parent.IsRed, grandparent.IsRed) = (grandparent.IsRed, parent.IsRed);
                        node = parent;//move up --if acces to if statement will move to grandparent
                    }
                }
                else//same as if statement but change change in left and right rotation
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
                    else//if uncle is black or null, we perform case 2 or case 3 that check the shape of the current node if Triangle or Line
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

        private Node FindNode(Node SearchInNode, int value)
        {
            if (SearchInNode == null || value == SearchInNode.Value)
                return SearchInNode;
            else if(value < SearchInNode.Value)
                SearchInNode = FindNode(SearchInNode.Left, value);
            else
                SearchInNode = FindNode(SearchInNode.Right, value);
            return SearchInNode;
        }

        public Node Find(int value)
        {
            return FindNode(root, value);
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
            rbTree.Insert(10);
            rbTree.Insert(20);
            rbTree.Insert(30);
            rbTree.Insert(15);
            rbTree.Insert(16);
            rbTree.Insert(17);


            rbTree.PrintTree();

            Console.WriteLine("Searching for 15");
            if(rbTree.Find(15) != null)
                Console.WriteLine("Found 15 in the tree.");
            else
                Console.WriteLine("15 not found in the tree.");

            Console.ReadKey();
        }
    }
}
