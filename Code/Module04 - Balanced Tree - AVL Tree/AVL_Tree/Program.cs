using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Tree
{
    class AVLNode
    {
        public int Value { get; set; }
        public AVLNode Left { get; set; }
        public AVLNode Right { get; set; }
        public int Height { get; set; }
        public AVLNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
            Height = 1;
        }
    }

    class AVLTree
    {
        private AVLNode root;

        public void Insert(int value)
        {
            root = Insert(root, value);
        }

        private AVLNode Insert(AVLNode node, int value)
        {
            //base case: when node = null will created and return
            if(node == null)
            {
                return new AVLNode(value);
            }

            //if less than current node insert in left sub tree
            if (value < node.Value)
            {
                node.Left = Insert(node.Left, value);
            }
            //if greater than current node insert in right sub tree
            else if(value > node.Value)
            {
                node.Right = Insert(node.Right, value);
            }
            else
            {
                return node;//deuplicate values are not allowed
            }

            //update the current node height
            UpdateHeight(node);

            //balance the tree after insertion
            return Balance(node);
        }


        public void Delete(int value)
        {
            root = Delete(root, value);
        }

        private AVLNode Delete(AVLNode node, int value)
        {
            //when there is no node to delete return null
            if (node == null) return node;

            if (value < node.Value)
            {
                node.Left = Delete(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = Delete(node.Right, value);
            }
            else
            {

                //check if the node has one child or no child
                if(node.Left == null)
                {
                    return node.Right;//when return the right child of the current node it will be assigned to the parent node of the current node and this will effectively delete the current node from the tree
                }
                else if(node.Right == null)
                {
                    return node.Left;//when return the left child of the current node it will be assigned to the parent node of the current node and this will effectively delete the current node from the tree
                }

                //if has two children get the samllest value in right and replace with current node value then delete the smallest value in right
                AVLNode samllestInRight = GetSamllestInRight(node.Right);

                //assign the value of the smallest node in the right subtree to the current node to replace the value of the current node with the smallest value in the right subtree
                node.Value = samllestInRight.Value;

                //delete the smallest node in the right subtree by his value
                node.Right = Delete(node.Right, samllestInRight.Value);
            }

            //update the current node height
            UpdateHeight(node);

            //balance the tree after deletion
            return Balance(node);

        }


        public bool Exists(int value)
        {
            return Exists(root, value);
        }

        private bool Exists(AVLNode node, int value)
        {
            if (node == null)
            {
                return false;//not found
            }
            if (value > node.Value)
            {
                return Exists(node.Right, value);
            }
            else if (value < node.Value)
            {
                return Exists(node.Left, value);
            }
            else
            {
                return true;//found
            }
        }


        public AVLNode Search(int value)
        {
            return Search(root, value);
        }

        private AVLNode Search(AVLNode node, int value)
        {
            if (node == null)
            {
                return null;//not found
            }
            if (value > node.Value)
            {
                return Search(node.Right, value);
            }
            else if (value < node.Value)
            {
                return Search(node.Left, value);
            }
            else 
            { 
                return node;
            }
        }

        private AVLNode GetSamllestInRight(AVLNode node)
        {
            AVLNode current = node;
            while(current.Left != null)
            {
                current = current.Left;
            }
            return current;
        }

        //get height of node
        private int Height(AVLNode node)
        {
            return node != null ? node.Height : 0;
        }

        //
        private void UpdateHeight(AVLNode node)
        {
            //after inserting the left and right node of current node we need to update the height
            //so we make the height equal 1 -> default height when created + height of left node and height of right node
            node.Height = 1 + System.Math.Max(Height(node.Left) , Height(node.Right));
        }


        //this function get the blance vactor of current node that tell us what should do -> left rotation or right rotaion
        //if return +2,+1 then -> right rotation
        //if -2,-1 then -> left rotation
        //if +2,-1 then -> left right rotation 
        //if -2,+1 then -> right left rotation
        //so the return value of this function will be used to determine the type of rotation needed to balance the tree after insertion
        private int GetBalanceFactor(AVLNode node)
        {
            return node != null ? Height(node.Left) - Height(node.Right) : 0;
        }

        

        private AVLNode Balance(AVLNode node)
        {
            int blanceFactor = GetBalanceFactor(node);

            //RR case
            //if return +2,+1 then -> right rotation
            if(blanceFactor > 1 && GetBalanceFactor(node.Left) >= 0)
            {
                return RightRotate(node);
            }

            //LL case
            // if return -2,-1 then -> left rotation
             if(blanceFactor < -1 && GetBalanceFactor(node.Right) <= 0)
            {
                return LeftRotate(node);
            }

            //LR case
            //if +2,-1 then -> left right rotation 
            if (blanceFactor > 1 && GetBalanceFactor(node.Left)<0)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            //RL case
            //if -2,+1 then -> right left rotation
            if (blanceFactor < -1 && GetBalanceFactor(node.Right) > 0)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }

            return node;
        }

        private AVLNode RightRotate(AVLNode OriginalRoot)
        {
            //in right rotation the left node of the original root will be the new root after rotation
            AVLNode newRoot = OriginalRoot.Left;

            //save the right child now in temp because after rotation it will be the left child of the original root
            AVLNode OriginalRightChild = newRoot.Right;

            //do the rotation
            //the original root will be the right child of the new root after rotation
            newRoot.Right = OriginalRoot;

            //the right child of the new root will be the left child of the original root after rotation
            OriginalRoot.Left = OriginalRightChild;

            //update heights
            //after rotation we need to update
            //the height of the original root and the new root
            //because their positions in the tree have changed
            UpdateHeight(OriginalRoot);
            UpdateHeight(newRoot);

            //Finally, the node NewRoot, which is now the root of this subtree after the rotation, is returned.
            return newRoot;
        }

        private AVLNode LeftRotate(AVLNode OriginalRoot)
        {
            //in left rotation the right node of the original root will be the new root of the subtree after rotation
            AVLNode newRoot = OriginalRoot.Right;

            //save the left child now in temp because after rotation it will be the right child of the original root
            AVLNode OriginalLeftChild = newRoot.Left;

            //do the rotation
            //the original root will be the left child of the new root after rotation
            newRoot.Left = OriginalRoot;

            //the left child of the new root will be the right child of the original root after rotation
            OriginalRoot.Right = OriginalLeftChild;

            //update heights
            //after rotation we need to update
            //the height of the original root and the new root
            //because their positions in the tree have changed
            UpdateHeight(OriginalRoot);
            UpdateHeight(newRoot);

            //Finally, the node NewRoot, which is now the root of this subtree after the rotation, is returned.
            return newRoot;
        }

        public void PrintTree()
        {
            PrintTree(root, "", true);
        }

        private void PrintTree(AVLNode node, string indent, bool last)
        {
            //base case: if node is null return
            if (node != null)
            {
                Console.Write(indent);
                if (last)
                {
                    Console.Write("R----");
                    indent += "     ";
                }
                else
                {
                    Console.Write("L----");
                    indent += "|    ";
                }
                Console.WriteLine(node.Value);
                PrintTree(node.Left, indent, false);
                PrintTree(node.Right, indent, true);
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AVLTree tree = new AVLTree();

            //RR
            // int[] values = { 10, 20, 30 };

            //LL
            //  int[] values = { 30, 20, 10 };

            //LR
            // int[] values = { 30, 10, 20 };

            //RL
            //int[] values = { 10, 30, 20 };

            // Inserting values
            int[] values = { 10, 20, 30, 40, 50, 25 };
            foreach (var value in values)
            {
                Console.WriteLine($"Inserting {value} into the AVL tree.");
                tree.Insert(value);
                tree.PrintTree();
                Console.WriteLine("\n-------------------------------------------------\n");
            }

            tree.Delete(40);
                Console.WriteLine($"Deleting 40 from the AVL tree.");
                tree.PrintTree();
                 Console.WriteLine("\n-------------------------------------------------\n");


            // Searching for values
            int searchValue = 30;
            bool found = tree.Exists(searchValue);
            Console.WriteLine($"\nSearch for value {searchValue}: " + (found ? "Found" : "Not Found"));

            searchValue = 60;
            found = tree.Exists(searchValue);
            Console.WriteLine($"Search for value {searchValue}: " + (found ? "Found" : "Not Found"));



            // Searching for values and printing the results
            int searchValue2 = 30;
            AVLNode foundNode = tree.Search(searchValue2);
            Console.WriteLine($"\nSearch for value {searchValue2}: " + (foundNode != null ? $"Found node with value: {foundNode.Value}" : "Not Found"));

            searchValue2 = 60;
            foundNode = tree.Search(searchValue);
            Console.WriteLine($"Search for value {searchValue2}: " + (foundNode != null ? $"Found node with value: {foundNode.Value}" : "Not Found"));

            Console.ReadKey();
        }
    }
}
